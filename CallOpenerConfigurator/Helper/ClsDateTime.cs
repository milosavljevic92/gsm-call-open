using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallOpenerConfigurator
{
    class DateTimeHelper
    {
        public static string getTimeStampForFile()
        {
            string year = DateTime.Now.ToString("yyyy");
            string month = DateTime.Now.ToString("MM");
            string day = DateTime.Now.ToString("dd");
            string hour = DateTime.Now.ToString("HH");
            string minute = DateTime.Now.ToString("mm");
            string second = DateTime.Now.ToString("ss");
            string tmp = $"{day}{month}{year}_{hour}{minute}{second}";
            return tmp;
        }
        public static string getDateTime()
        {
            DateTime myDate = DateTime.Now;
            string year = DateTime.Now.ToString("yyyy");
            string month = DateTime.Now.ToString("MM");
            string day = DateTime.Now.ToString("dd");
            string hour = DateTime.Now.ToString("HH");
            string minute = DateTime.Now.ToString("mm");
            string second = DateTime.Now.ToString("ss");
            return day + "." + month + "." + year + " " + hour + ":" + minute + ":" + second;
        }

    }
}
