using System;
using TestingFramework.Framework.Helpers;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace TestingFramework.Framework.Items
{
    public class TFItem<T> where T : UIItem
    {
        protected T uiItem;
        protected string friendlyName;

        protected TFItem()
        {
        }
        protected TFItem(UIItem uiItem)
        {
            this.uiItem = (T)uiItem;
        }

        protected TFItem<T> GetItem(SearchCriteria searchCriteria, string windowName, string friendlyName)
        {
            var window = WindowHelper.GetWindow(windowName);
            try
            {
                uiItem = window.Get<T>(searchCriteria);
            }catch(Exception ex)
            {
                LogWriter.GetLogger().Error("Failed to capture object {friendlyName}", friendlyName);
                LogWriter.GetLogger().Debug(ex);
            }
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

        public UIItem Item()
        {
            return uiItem;
        }
    }
}
