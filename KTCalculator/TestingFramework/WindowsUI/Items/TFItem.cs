using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Automation;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Actions;
using TestStack.White.UIItems.Scrolling;
using TestStack.White.UIItems.WPFUIItems;
using TestStack.White.WindowsAPI;

namespace TestingFramework.WindowsUI.Items
{
    public class TFItem<T>: ITFItem where T : UIItem
    {
        private T uiItem;

        protected TFItem(T uiItem, string friendlyName)
        {
            this.uiItem = uiItem;
            this.FriendlyName = friendlyName;
        }

        public bool UIItemExists => uiItem != null;
        public string FriendlyName { get; set; }
        public T UIItem
        {
            get
            {
                if(this.uiItem == null)
                {
                    throw new Exception("ui item is null");
                }
                return this.uiItem;
            }
        }
         
        public bool Exists
        {
            get
            {
                if (!this.UIItem.Visible)
                {
                    return false;
                }
                return true;
                
            }
        }

        public bool Enabled => throw new NotImplementedException();

        public bool isVisible => UIItem.Visible;

        public string Name => UIItem.Name;

        //public virtual string Value => UIItem.AutomationElement.GetValue();
        public Point Location => UIItem.Location;
        public Rect Bounds => UIItem.Bounds;
        
        public void Click()
        {
            //log
            UIItem.Click();
        }

        public void RightClick()
        {
            //log
            UIItem.RightClick();
        }

    }
}
