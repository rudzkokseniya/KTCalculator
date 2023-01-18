using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace TestingFramework.Framework.Items
{
    public class TFButton : TFItem<Button>
    {
        public TFButton()
            : base()
        {
        }

        public new TFButton GetItem(SearchCriteria searchCriteria, string windowName, string friendlyName)
        {
            LogWriter.GetLogger().Debug("Captured {friendlyName} button", friendlyName);
            return (TFButton)base.GetItem(searchCriteria, windowName, friendlyName);
        }

        public new void Click()
        {
            LogWriter.GetLogger().Debug("{friendlyName} button clicked", friendlyName);
            base.Click();
        }
    }
}
