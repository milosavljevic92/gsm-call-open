using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallOpenerConfigurator
{
    class LogFile
    {
        public static void New(string logType, string logMessage)
        {
            try
            {
                string lines = DateTime.Now.ToString() + " # logType: " + logType + " # " + "msg: " + logMessage;
                System.IO.File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + "_app.log", "\r\n" + lines);
            }
            catch { }
        }
    }
}
