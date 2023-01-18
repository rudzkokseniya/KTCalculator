using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace TestingFramework.Framework.Items
{
    public class TFLabel : TFItem<Label>
    {
        public TFLabel(SearchCriteria searchCriteria, string windowName, string friendlyName)
            : base(searchCriteria, windowName, friendlyName)
        {
            LogWriter.GetLogger().Debug("{friendlyName} button captured", friendlyName);
        }

        public new string GetName()
        {
            LogWriter.GetLogger().Debug("{friendlyName} label name returned", friendlyName);
            return base.GetName();
        }
    }
}
