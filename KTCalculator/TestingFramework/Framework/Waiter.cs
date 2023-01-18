using System;
using System.Diagnostics;
using System.Threading;

namespace TestingFramework.Framework
{
    public static class Waiter
    {
        public static bool WaitUntil(Func<bool> condition, int timeoutMiliseconds, string reportMessage)
        {
            TimeSpan timeSpan = TimeSpan.FromMilliseconds(timeoutMiliseconds);
            bool flag = false;
            Stopwatch stopwatch = new Stopwatch();
            while(!flag && stopwatch.Elapsed < timeSpan)
            {
                Thread.Sleep(100);
                try
                {
                    flag = condition();
                }
                catch(Exception ex)
                {
                    LogWriter.GetLogger().Debug("Exception during waiting: {exceptionMessage}", ex.Message);
                }
            }
            stopwatch.Stop();
            LogWriter.GetLogger().Debug("{reportMessage} action {flag} finished after waiting for {miliseconds} miliseconds", reportMessage, flag ? "was" : "wasn't", stopwatch.Elapsed);
            return stopwatch.Elapsed < timeSpan;
        }
        public static void Wait(int timeoutMiliseconds)
        {
            Thread.Sleep(timeoutMiliseconds);
        }
    }
}
