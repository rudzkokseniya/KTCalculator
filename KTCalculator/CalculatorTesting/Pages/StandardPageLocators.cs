using System.Collections.Generic;
using System.Linq;
using Testing.Utils;
using TestingFramework.Framework.Items;
using TestStack.White.UIItems.Finders;

namespace Testing.Pages
{
    public partial class StandardPage
    {
        protected TFButton DecimalSeparatorButton => new TFButton().GetItem(SearchCriteria.ByAutomationId("84"), Constants.CALCULATOR_WINDOW, "Decimal separator");
        protected TFButton AddButton => new TFButton().GetItem(SearchCriteria.ByAutomationId("93"), Constants.CALCULATOR_WINDOW, "Add");
        protected TFButton EqualsButton => new TFButton().GetItem(SearchCriteria.ByAutomationId("121"), Constants.CALCULATOR_WINDOW, "Equals");
        protected TFButton MemoryAddButton => new TFButton().GetItem(SearchCriteria.ByAutomationId("125"), Constants.CALCULATOR_WINDOW, "Memory add");
        protected TFButton MemoryRecallButton => new TFButton().GetItem(SearchCriteria.ByAutomationId("123"), Constants.CALCULATOR_WINDOW, "Memory recall");
        protected TFLabel ResultLabel => new TFLabel().GetItem(SearchCriteria.ByAutomationId("150"), Constants.CALCULATOR_WINDOW, "Result");
        protected List<TFButton> DigitButtons => TFButton.GetAllButtons(Constants.CALCULATOR_WINDOW).Where(b => b.GetName().Length == 1 && char.Parse(b.GetName()) >= '0' && char.Parse(b.GetName()) <= '9').ToList();
    }
}
