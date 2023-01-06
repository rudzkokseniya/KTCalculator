using System.Windows;
namespace TestingFramework.WindowsUI
{
    public interface ITFItem
    {
        bool Enabled { get; }
        bool Exists { get; }
        bool UIItemExists { get; }
        bool isVisible { get; }
        string Name { get; }
        string FriendlyName { get; }
        Point Location { get; }
        Rect Bounds { get; }
        
        void Click();
        void RightClick();
    }
}
