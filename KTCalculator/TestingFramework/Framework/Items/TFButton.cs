using System.Collections.Generic;
using System.Windows.Automation;
using TestingFramework.Framework.Helpers;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace TestingFramework.Framework.Items
{
    public class TFButton : TFItem<Button>
    {
        public TFButton()
            : base()
        {
        }

        public TFButton(UIItem uiItem)
            : base(uiItem)
        {
        }

        public new TFButton GetItem(SearchCriteria searchCriteria, string windowName, string friendlyName)
        {
            LogWriter.GetLogger().Debug("Capturing {friendlyName} button", friendlyName);
            return (TFButton)base.GetItem(searchCriteria, windowName, friendlyName);
        }

        public static List<TFButton> GetAllButtons(string windowName)
        {
            Window scope = WindowHelper.GetWindow(windowName);
            IUIItem[] array = scope.GetMultiple(SearchCriteria.ByClassName("Button").AndControlType(ControlType.Button));
            List<TFButton> list = new List<TFButton>();
            foreach(IUIItem item in array)
            {
                list.Add(new TFButton((Button)item));
            }
            return list;
        }

        public new string GetName()
        {
            LogWriter.GetLogger().Debug("{friendlyName} button name returned", friendlyName);
            return base.GetName();
        }

        public new void Click()
        {
            LogWriter.GetLogger().Debug("{friendlyName} button clicked", friendlyName);
            base.Click();
        }
    }
}
