using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace TestingFramework.Framework.Items
{
    public class TFButton : TFItem<Button>
    {
        public TFButton(SearchCriteria searchCriteria, string windowName, string friendlyName)
            : base(searchCriteria, windowName, friendlyName)
        {
            LogWriter.GetLogger().Debug("{friendlyName} button captured", friendlyName);
        }

        public new void Click()
        {
            LogWriter.GetLogger().Debug("{friendlyName} button clicked", friendlyName);
            base.Click();
        }
    }
}
