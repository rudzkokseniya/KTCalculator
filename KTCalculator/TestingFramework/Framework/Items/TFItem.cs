using TestingFramework.Framework.Helpers;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace TestingFramework.Framework.Items
{
    public abstract class TFItem<T> where T : UIItem
    {
        protected T uiItem;
        protected string friendlyName;

        protected TFItem()
        {
        }

        protected TFItem<T> GetItem(SearchCriteria searchCriteria, string windowName, string friendlyName)
        {
            var window = WindowHelper.GetWindow(windowName);
            uiItem = window.Get<T>(searchCriteria);
            this.friendlyName = friendlyName;
            return this;
        }

        protected string GetName()
        {
            return uiItem.Name;
        }

        protected void Click()
        {
            uiItem.Click();
        }
    }
}
