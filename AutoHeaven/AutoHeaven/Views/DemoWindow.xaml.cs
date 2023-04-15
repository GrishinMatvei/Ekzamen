using AutoHeaven.Model;
using System.Linq;
using System.Windows;

namespace AutoHeaven.Views
{
    public partial class DemoWindow : Window
    {
        public DemoWindow()
        {
            InitializeComponent();
            UpdateList();
        }

        public void UpdateList()
        {
            var list = AutoHeavenEntities.GetContext().Order.ToList();
            orderList.ItemsSource = list;
        }
    }
}
