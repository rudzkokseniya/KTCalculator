using System;
using TestStack.White.UIItems.WindowItems;

namespace TestingFramework.Framework.Helpers
{
    public static class WindowHelper
    {
        public static Window GetWindow(string windowName)
        {
            try
            {
                var window = ApplicationController.Get().GetApplication().GetWindow(windowName);
                LogWriter.GetLogger().Debug("Captured window {windowName}", windowName);
                return window;
            }
            catch (Exception exception)
            {
                LogWriter.GetLogger().Error("Error finding window {windowName}", windowName);
                throw exception;
            }
        }
    }
}
