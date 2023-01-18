using System;
using TestStack.White;

namespace TestingFramework.Framework
{
    public static class ApplicationController
    {
        private static Application application = null;

        public static void StartApplication(string applicationPath)
        {
            LogWriter.GetLogger().Debug("Starting application {path}", applicationPath);

            try
            {
                application = Application.Launch(applicationPath);
            }
            catch(Exception exception)
            {
                LogWriter.GetLogger().Error("Application started incorrectly / Wrong application path");
                throw exception;
            }
        }

        public static void StopApplication()
        {
            LogWriter.GetLogger().Debug("Application closing");
            application.Close();
            LogWriter.GetLogger().Debug("Application closed");
        }

        public static Application GetApplication()
        {
            return application;
        }
    }
}
