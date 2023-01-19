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
            LogWriter.GetLogger().Debug("Capturing {friendlyName} menu", friendlyName);
            return (TFMenu)base.GetItem(searchCriteria, windowName, friendlyName);
        }

        public TFMenu GetItemByPath(Menu menu, string friendlyName)
        {
            this.uiItem = menu;
            this.friendlyName = friendlyName;
            return this;
        }

        public new void Click()
        {
            base.Click();
            LogWriter.GetLogger().Debug("{friendlyName} menu item clicked", friendlyName);
        }
    }
}
