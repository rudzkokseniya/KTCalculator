using System.Windows.Forms;
using TestingFramework.Framework;
using TestingFramework.Framework.Items;
using TestStack.White;
using TestStack.White.UIItems.Finders;
namespace TestingFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationController.StartApplication("C:\\Program Files\\OldClassicCalc\\calc1.exe");
            TFButton button = new TFButton(SearchCriteria.ByAutomationId("131"), "Calculator", "1Button");
            button.Click();
        }
    }
}
