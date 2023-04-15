using System.Windows.Controls;
using System.Windows;

namespace AutoHeaven.Extentions
{
    public static class ButtonExtentions
    {
        public static void PerformClick(this Button button)
        {
            button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
        }
    }
}
