using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO.Ports;
using CallOpenerConfigurator;
using System.Globalization;

class Communication
{
    private static readonly SerialPort _serialPort = new SerialPort();
    public static string siteName { get; set; }
    public static string master1 { get; set; }
    public static string master2 { get; set; }
    public static string relayDelay { get; set; }
    public static string numbers { get; set; }
    public static string infoDeviceName { get; set; }
    public static string infoDeviceVer { get; set; }
    public static string infoFirmwareVer { get; set; }
    public static string infoManufacterDate { get; set; }
    public static string InfoSN { get; set; }

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
    public static bool getDeviceStatus()
    {
        _stateMachine = 1;
        writeToSerial("Hello");
        return true;
    }
    private static void Read()
    {
        while (_continue)
        {
            try
            {
                if (!checkIsPortOpen()) _continue = false;
                string inputData = _serialPort.ReadLine();
                switch (_stateMachine)
                {
                    case 1:
                        string[] buffer = inputData.Split(',');
                        //ScaleWeight = buffer[2].Replace(" ", string.Empty);
                        break;
                    case 2:

                        break;
                }
            }
            catch (Exception ex)
            {
                LogFile.New("ERROR", "ERROR WITH COMMUNICATION : " + ex.Message);
            }
        }
    }
    public static void writeAll ()
    {

    }
    public static void readAll ()
    {
        
    }
    private static void writeToSerial(string data)
    {
        if (_serialPort.IsOpen == true)
        {
            _serialPort.WriteLine($"{data}\r");
        }
    }
}
