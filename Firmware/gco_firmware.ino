#include <SoftwareSerial.h>
#include <EEPROM.h>

#define RELAY  23

SoftwareSerial SIM800(8, 7);

String inputString;
int stateMachine = 0;

buffer.reserve(200);
phone.reserve(20);
temp.reserve(200);

pinMode(RELAY, OUTPUT);
digitalWrite(RELAY, LOW);

void setup() {
  Serial.begin(9600);
  SIM800.begin(9600);

  delay(1000);
  SIM800.write("AT\r");  // because of SIM800L autobounding mode
  delay(1000);
  SIM800.write("AT+IPR=9600\r");  // set baud on SIM800l at 9600
  delay(1000);
  SIM800.write("AT+CMGF=1\r");  // set SMS mode to text
  delay(1000);
  SIM800.write("AT+CNMI=2,2,0,0,0\r");
  delay(1000);
  Serial.print(SIM800.readString());
  SIM800.write("AT+CLIP=1\r\n");
  delay(1000);
  SIM800.write("AT+SGPIO=0,7,1,0\r");
  delay(1000);
  SIM800.write("AT+CSCLK=2\r"); //power saving mode of SIM800L
  delay(1000);
}

void loop() {
if(Serial.available() > 0) { 
  receiveVal = Serial.read(); 
  switch (reciveVal) {
    case "Hello":
      Serial.print("Hi");
    break
    case "GetDeviceInfo":
      Serial.print("GCO;1.0;0.9;0922;0007\r"); //name;device ver;fw ver;dateyear;sn
    break
    case "GetPhoneNumbers"
      Serial.print(readStringFromEEPROM(50));
    break
    case "GetConfig"
      Serial.print(readStringFromEEPROM(50));
    break
  }
}
if (SIM800.available() > 0) goto loop;
  switch (stateMachine) {
    case 0:
      //ERROR
      break
    case 1:
      //WriteNewNumberViaSms  
      break;
    case 2:

      break;
    default:
      if (SIM800.available() > 0) break
      buffer = SIM800.readStringUntil('\n');
      Serial.println(buffer);   
      if (checkInMemory(parseNumber())) triggerRelay ();
      break;
  }
} 
String parseNumber() {
  if (buffer.indexOf("CLIP:") > 0) {
    phone = buffer.substring(buffer.indexOf("+CLIP: ") + 8, buffer.indexOf("+CLIP: ") + 381); //parsing caller number
    Serial.println(phone);
    SIM800.write("ATH\r"); //hang out phone call
    delay(500);     
  }
  return phone;  
}

bool checkInMemory (string number) {
  int sa[50], r=0, t=0;
  temp = readStringFromEEPROM (50)

  for (int i=0; i < temp.length(); i++) { 
    if(temp.charAt(i) == ';') { 
        if (number == oneLine.substring(r, i).toInt())
            return true;    
        r=(i+1);    
    }
  }
  return false;  
}

void triggerRelay {
  digitalWrite(RELAY, HIGH);
  delay(1000);
  digitalWrite(RELAY, LOW);
}

void writeStringToEEPROM(int addrOffset, const String &strToWrite) {
  byte len = strToWrite.length();
  EEPROM.write(addrOffset, len);
  for (int i = 0; i < len; i++)
  {
    EEPROM.write(addrOffset + 1 + i, strToWrite[i]);
  }
}

String readStringFromEEPROM(int addrOffset) {
  int newStrLen = EEPROM.read(addrOffset);
  char data[newStrLen + 1];
  for (int i = 0; i < newStrLen; i++)
  {
    data[i] = EEPROM.read(addrOffset + 1 + i);
  }
  data[newStrLen] = '\ 0'; // !!! NOTE !!! Remove the space between the slash "/" and "0" (I've added a space because otherwise there is a display bug)
  return String(data);
}