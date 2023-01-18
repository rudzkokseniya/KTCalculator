using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace TestingFramework.Framework.Items
{
    public class TFLabel : TFItem<Label>
    {
        public TFLabel()
            : base()
        {
        }

        public new TFLabel GetItem(SearchCriteria searchCriteria, string windowName, string friendlyName)
        {
            LogWriter.GetLogger().Debug("Captured {friendlyName} label", friendlyName);
            return (TFLabel)base.GetItem(searchCriteria, windowName, friendlyName);
        }

        public new string GetName()
        {
            LogWriter.GetLogger().Debug("{friendlyName} label name returned", friendlyName);
            return base.GetName();
        }
    }
}
