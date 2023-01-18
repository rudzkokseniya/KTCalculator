using System.Diagnostics;

namespace TestingFramework.Framework.Helpers
{
    public static class ProcessHelper
    {
        public static void KillAll(string processName)
        {
            foreach(var process in Process.GetProcessesByName(processName)){
                process.Kill();
                LogWriter.GetLogger().Debug("Killed process {process}", processName);

            }
        }
    }
}
