using Testing.Utils;
using TestingFramework.Framework.Items;
using TestStack.White.UIItems.Finders;

namespace Testing.Pages
{
    public partial class ScientificPage
    {
        protected TFButton SquareResultButton => new TFButton().GetItem(SearchCriteria.ByAutomationId("111"), Constants.CALCULATOR_WINDOW, "Square result");
    }
}
