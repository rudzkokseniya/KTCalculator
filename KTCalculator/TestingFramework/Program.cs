using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch =true)]
namespace TestingFramework
{
    internal class Program
    {
        private static readonly log4net.ILog log = Logging.LogHelper.GetLogger();
        static void Main(string[] args)
        {
            Console.WriteLine("Henlo world");
            log.Error("eh");
            log.Error("eh");
        }
    }
}
