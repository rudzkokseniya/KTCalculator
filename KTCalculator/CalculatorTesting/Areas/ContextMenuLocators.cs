using TestStack.White.UIItems.Finders;
using TestingFramework.Framework.Items;
using Testing.Utils;

namespace CalculatorTesting.Areas
{
    partial class ContextMenu
    {
        public TFMenuBar MainMenuBar => new TFMenuBar().GetItem(SearchCriteria.ByAutomationId("MenuBar"), Constants.CALCULATOR_WINDOW, "Main");
        public TFMenu ViewMenuItem(string name) => new TFMenu().GetItem(SearchCriteria.ByText(name), Constants.CALCULATOR_WINDOW, name);

    }
}
