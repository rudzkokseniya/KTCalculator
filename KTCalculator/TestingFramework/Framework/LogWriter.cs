using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingFramework.Framework
{
    public static class LogWriter
    {
        private static NLog.Logger logger = null;

        public static NLog.Logger GetLogger()
        {
            if (logger == null)
            {
                logger = NLog.LogManager.GetLogger("MyLogger");
            }
            return logger;
        }
    }
}
