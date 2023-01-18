using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace TestingFramework.Framework.Items
{
    public abstract class TFItem<T> where T : UIItem
    {
        protected T uiItem;
        protected string friendlyName;

        protected TFItem(SearchCriteria searchCriteria, string windowName, string friendlyName)
        {
            this.friendlyName = friendlyName;
            GetItem(searchCriteria, windowName);
        }

        protected TFItem<T> GetItem(SearchCriteria searchCriteria, string windowName)
        {
            var window = ApplicationController.GetWindow(windowName);
            uiItem = window.Get<T>(searchCriteria);
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
