using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO.Ports;
using CallOpenerConfigurator;

class Communication
{
    private static readonly SerialPort _serialPort = new SerialPort();
    public static string siteName { get; set; }
    public static string master1 { get; set; }
    public static string master2 { get; set; }
    public static string relayDelay { get; set; }
    public static string phoneNumbers { get; set; }
    public static string infoDeviceName { get; set; }
    public static string infoDeviceVer { get; set; }
    public static string infoFirmwareVer { get; set; }
    public static string infoManufacterDate { get; set; }
    public static string InfoSN { get; set; }

    public static bool checkIsLive { get; set; } 

    static bool _continue = false;
    static int _stateMachine = 0;
    public static bool checkIsPortOpen()
    {
        return _serialPort.IsOpen;
    }
    public static bool SetStart(string commPort = "COM1")
    {
        try
        {
            int baundRate = 9600;
            _serialPort.PortName = commPort;
            _serialPort.BaudRate = baundRate;
            _serialPort.Parity = _serialPort.Parity;
            _serialPort.DataBits = _serialPort.DataBits;
            _serialPort.StopBits = _serialPort.StopBits;
            _serialPort.Handshake = _serialPort.Handshake;
            _serialPort.DtrEnable = true;

            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;
            _serialPort.Open();

            _continue = true;
            if (_serialPort.IsOpen == true)
            {
                _serialPort.WriteLine("\r");
                Thread readThread = new Thread(Read);
                readThread.Start();
                return true;
            }
            else
                return false;
        }
        catch { return false; }
    }
    public static bool SetStop()
    {
        try
        {
            _continue = false;
            _serialPort.Close();
        }
        catch { }
        return true;
    }
    private static void Read()
    {
        string[] buffer;
        while (_continue)
        {
            try
            {
                if (!checkIsPortOpen()) _continue = false;
                string inputData = _serialPort.ReadLine();
                _stateMachine = 1;
                switch (_stateMachine)
                {
                    case 0:
                        buffer = inputData.Split(';');
                        if (buffer[0] == "Hi")
                            checkIsLive = true;
                        else
                            checkIsLive = false;
                        break;

                    case 1:
                        buffer = inputData.Split(';');
                        infoDeviceName = buffer[0];
                        infoDeviceVer = buffer[1];
                        infoFirmwareVer = buffer[2];
                        infoManufacterDate = buffer[3];
                        InfoSN = buffer[4];
                        break;

                    case 2:
                        buffer = inputData.Split(';');
                        siteName = buffer[0];
                        master1 = buffer[1];
                        master2 = buffer[2];
                        relayDelay = buffer[3];
                        break;

                    case 3:
                        phoneNumbers = inputData;                  
                        break;

                    default:
                       break;
                }
            }
            catch (Exception ex)
            {
                LogFile.New("ERROR", "ERROR WITH COMMUNICATION : " + ex.Message);
            }
        }
    }
    public static void writeAll()
    {
        writePhoneNumbers();
        writeConfiguration();
    }
    public static void readAll()
    {
        writeToSerial("");
    }
    public static void checkConectivity()
    {
        writeToSerial("GetHello");
    }
    public static void readDeviceInfo ()
    {
        writeToSerial("GetDeviceInfo");
    }
    public static void readConfig()
    {      
        writeToSerial("GetConfig");
    }
    public static void readPhoneNumbers ()
    {
        writeToSerial("GetPhoneNumbers");
    }
    private static void writePhoneNumbers()
    {
        writeToSerial("Set-PhoneNumbers" + " " + phoneNumbers);
    }
    private static void writeConfiguration()
    {
        writeToSerial("Set-Configuration" + " " + siteName + ";" + master1 + ";" + master2 + ";" + relayDelay);
    }

    private static void writeToSerial(string data)
    {
        if (_serialPort.IsOpen == true)
        {
            _serialPort.Write($"{data}");
        }
    }
}