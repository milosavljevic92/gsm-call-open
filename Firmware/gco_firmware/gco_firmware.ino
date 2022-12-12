#include <SoftwareSerial.h>
#include <EEPROM.h>

#define SIM800_RX_PIN 3
#define SIM800_TX_PIN 2
#define SIM800_RST_PIN 6
#define RELAY_PIN 13

SoftwareSerial SIM800(SIM800_RX_PIN, SIM800_TX_PIN);

String inputString;
String buffer;
String phone;
String temp;
String oneLine;
String receiveVal;
int Sim800l_tx_pause = 200;
int state_serial = 0;
int state_sim800 = 0;

String deviceName = "GCO";
String deviceVer = "1.0";
String deviceFirmwareVersion = "0.9";
String deviceManufactureDate = "1223";
String deviceSN = "0007";

void setup() {
  Serial.begin(9600);
  SIM800.begin(9600);
Serial.write("Hello from tecomatic.net");
  buffer.reserve(200);
  phone.reserve(20);
  temp.reserve(200);

  pinMode(RELAY_PIN, OUTPUT);
  digitalWrite(RELAY_PIN, LOW);

}

void initSim800(){
  SIM800.write("AT\r");  // because of SIM800L autobounding mode
  delay(Sim800l_tx_pause);
  SIM800.write("AT+IPR=9600\r");  // set baud on SIM800l at 9600
  delay(Sim800l_tx_pause);
  SIM800.write("AT+CMGF=1\r");  // set SMS mode to text
  delay(Sim800l_tx_pause);
  SIM800.write("AT+CNMI=2,2,0,0,0\r");
  delay(Sim800l_tx_pause);
  Serial.print(SIM800.readString());
  SIM800.write("AT+CLIP=1\r\n");
  delay(Sim800l_tx_pause);
  SIM800.write("AT+SGPIO=0,7,1,0\r");
  delay(Sim800l_tx_pause);
  SIM800.write("AT+CSCLK=2\r"); //power saving mode of SIM800L
  delay(Sim800l_tx_pause);
}

void loop() {
  if(Serial.available() > 0) { 
    receiveVal = Serial.readString(); 
    receiveVal.trim();
    Serial.print(receiveVal+"\r");
    if (receiveVal == "GetHello")
      Serial.print("Hi\r");
    if (receiveVal == "GetDeviceInfo")
      Serial.print(deviceName + deviceVer + deviceFirmwareVersion +deviceManufactureDate + deviceSN +"\r");
    if (receiveVal == "GetPhoneNumbers")      
      Serial.print(readStringFromEEPROM(50));           
    if (receiveVal == "GetConfig")  
      Serial.print(readStringFromEEPROM(0));           
    if (receiveVal == "SetConfig")      
      writeStringToEEPROM(1,receiveVal);    
    if (receiveVal == "SetPhoneNumbers")  
      writeStringToEEPROM(50,receiveVal);    
  }
  if (SIM800.available() > 0) {
      switch (state_sim800) {
        case 0:
          //ERROR
        break;
        case 1:
          //WriteNewNumberViaSms  
        break;
        default:
          if (SIM800.available() > 0) break;
          buffer = SIM800.readStringUntil('\n');
          Serial.println(buffer);   
          if (checkInMemory(parseNumber())) triggerRelay();
        break;
      }
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

bool checkInMemory(String number) {
  int sa[50], r=0, t=0;
  temp = readStringFromEEPROM(50);

  for (int i=0; i < temp.length(); i++){ 
    if(temp.charAt(i) == ';'){ 
        if (number == oneLine.substring(r, i).toInt())
            return true;    
        r=(i+1);    
    }
  }
  return false;  
}

void triggerRelay() {
  digitalWrite(RELAY_PIN, HIGH);
  delay(1000);
  digitalWrite(RELAY_PIN, LOW);
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