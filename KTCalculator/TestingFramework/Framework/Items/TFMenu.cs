using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;

namespace TestingFramework.Framework.Items
{
    public class TFMenu : TFItem<Menu>
    {
        public TFMenu()
            : base()
        {
        }

        public new TFMenu GetItem(SearchCriteria searchCriteria, string windowName, string friendlyName)
        {
            LogWriter.GetLogger().Debug("Captured {friendlyName} menu", friendlyName);
            return (TFMenu)base.GetItem(searchCriteria, windowName, friendlyName);
        }
        public new void Click()
        {
            LogWriter.GetLogger().Debug("{friendlyName} menu item clicked", friendlyName);
            base.Click();
        }
    }
}
