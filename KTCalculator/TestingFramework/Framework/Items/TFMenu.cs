using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;

namespace TestingFramework.Framework.Items
{
    public class TFMenu : TFItem<Menu>
    {
        public TFMenu(SearchCriteria searchCriteria, string windowName, string friendlyName)
            : base(searchCriteria, windowName, friendlyName)
        {
            LogWriter.GetLogger().Debug("{friendlyName} menu item captured", friendlyName);
        }
        public new void Click()
        {
            LogWriter.GetLogger().Debug("{friendlyName} menu item clicked", friendlyName);
            base.Click();
        }
    }
}
