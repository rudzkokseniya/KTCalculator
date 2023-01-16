using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Logging;

[assembly: log4net.Config.XmlConfigurator(Watch =true)]
namespace TestingFramework
{
    internal class Program
    {
        private static readonly log4net.ILog log = Logging.LogHelper.GetLogger();
        static void Main(string[] args)
        {
            LogHelper.GetLogger().Debug("aaa");
        }
    }
}
