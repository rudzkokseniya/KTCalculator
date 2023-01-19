using System;
using TestStack.White;

namespace TestingFramework.Framework
{
    public class ApplicationController
    {

        private static ApplicationController controller;

        private Application application = null;
        ApplicationController() {

        }
        public void StartApplication(string applicationPath)
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

        public void StopApplication()
        {
            application.Close();
            LogWriter.GetLogger().Debug("Application closed");
        }

        public  Application GetApplication()
        {
            return application;
        }

        public static ApplicationController Get()
        {
            if(controller == null)
            {
                controller = new ApplicationController();  
            }
            return controller;
        }
    }
}
