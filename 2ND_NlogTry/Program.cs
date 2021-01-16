using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ND_NlogTry
{
    class Program
    {
        static void Main(string[] args)
        {
            var Logger = NLog.LogManager.GetCurrentClassLogger();
            Logger.Log(LogLevel.Info, $"Proje Başladı {DateTime.Now.ToString("dd.MM.yyyy hh:ss")}");
            Logger.Log(LogLevel.Warn, $"Warning Mesajı {DateTime.Now.DayOfYear.ToString()}");
            Logger.Log(LogLevel.Info, $"Proje Bitti {DateTime.Now.ToString("dd.MM.yyyy hh:ss")}");
        }
    }
}
