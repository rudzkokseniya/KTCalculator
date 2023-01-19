using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowStripControls;

namespace TestingFramework.Framework.Items
{
    public class TFMenuBar : TFItem<MenuBar>
    {
        public TFMenuBar()
            : base()
        {
        }

        public new TFMenuBar GetItem(SearchCriteria searchCriteria, string windowName, string friendlyName)
        {
            LogWriter.GetLogger().Debug("Captured {friendlyName} label", friendlyName);
            return (TFMenuBar)base.GetItem(searchCriteria, windowName, friendlyName);
        }

        public TFMenu FindMenuItem(string path)
        {
            return new TFMenu().GetItemByPath(base.uiItem.TopLevelMenu.Find(path), path);
        }
    }
}
