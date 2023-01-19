using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
