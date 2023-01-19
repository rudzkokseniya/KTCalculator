using TestingFramework.Framework;

namespace CalculatorTesting.Areas
{
    partial class ContextMenu
    {
        public void OpenView()
        {
            MainMenuBar.FindMenuItem("View").Click();
        }

        public void SelectViewItem(string name)
        {
            ViewMenuItem(name).Click();
            Waiter.Wait(250);
        }
    }
}
