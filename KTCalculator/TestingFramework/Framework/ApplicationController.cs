using System;
using System.Collections.Generic;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems.WindowItems;

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

        public static Window GetWindow(string windowName)
        {
            try
            {
                LogWriter.GetLogger().Debug("Capturing window {windowName}", windowName);
                var window = application.GetWindow(windowName);
                LogWriter.GetLogger().Debug("Captured window {windowName}", windowName);
                return window;
            }
            catch (NullReferenceException exception)
            {
                if(application == null)
                {
                    LogWriter.GetLogger().Error("Application not initialized");
                    throw exception;
                }
                else
                {
                    LogWriter.GetLogger().Error("Window {windowName} not found", windowName);
                    throw exception;
                }
            }
        }

        public static List<Window> GetWindows()
        {
            try
            {
                var windows = application.GetWindows();
                return windows;
            }catch(NullReferenceException exception)
            {
                throw exception;
            }

        }
    }
}
