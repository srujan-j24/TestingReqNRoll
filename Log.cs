using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqnrollProject
{
    public static  class Log
    {
        public static readonly string logFile = "TestLog.txt";

        public static void Info(string message)
        {
            File.AppendAllText(logFile, $"{DateTime.Now:HH:mm:ss} - {message}{Environment.NewLine}");
        }
    }
}
