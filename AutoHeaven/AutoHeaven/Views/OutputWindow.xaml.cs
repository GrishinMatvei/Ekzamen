using AutoHeaven.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AutoHeaven.Views
{
    /// <summary>
    /// Логика взаимодействия для OutputWindow.xaml
    /// </summary>
    public partial class OutputWindow : Window
    {
        public OutputWindow(Personal user)
        {
            InitializeComponent();
            filterSelector.ItemsSource = AutoHeavenEntities.GetContext().Status.ToArray(); 
            UpdateDataGrid();
        }

        public void UpdateDataGrid()
        {
            ordersDataGrid.ItemsSource = AutoHeavenEntities.GetContext().Order.ToList();
        }

        public void UpdateDataGrid(string filter)
        {
            if (String.IsNullOrWhiteSpace(filter))
                return;

            ordersDataGrid.ItemsSource = AutoHeavenEntities.GetContext().Order.Where(o => o.Status.StatusName == filter).ToList();
        }

        private void ordersDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Order order = ordersDataGrid.SelectedItem as Order;
            OrderService orderSer = AutoHeavenEntities.GetContext().OrderService.FirstOrDefault(os => os.OrderId == order.Id);
            ProblemListWindow problemListWindow = new ProblemListWindow(orderSer);
            problemListWindow.ShowDialog();
        }

        private void filterEnable_Click(object sender, RoutedEventArgs e)
        {
            string filter = filterSelector.Text;
            UpdateDataGrid(filter);
        }

        private void filterDisable_Click(object sender, RoutedEventArgs e)
        {
            UpdateDataGrid();
        }

        private void searchField_TextInput(object sender, TextCompositionEventArgs e)
        {
            ordersDataGrid.ItemsSource = AutoHeavenEntities.GetContext().Order.Where(o => o.Auto.StateNumber.ToLower() == e.Text.ToLower()).ToList();
        }
    }
}
