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
    /// Логика взаимодействия для ProblemListWindow.xaml
    /// </summary>
    public partial class ProblemListWindow : Window
    {
        OrderService OrderSer { get; set; }
        public ProblemListWindow(OrderService orderSer)
        {
            InitializeComponent();
            OrderSer = orderSer;
            UpdateDataGrid();
        }
        
        protected void UpdateDataGrid()
        {
            var list = AutoHeavenEntities.GetContext().Service.Where(ser => ser.Id == OrderSer.Service).ToList();
            if (list is null)
            {
                MessageBox.Show("Автомобиль не найден", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Close();
            }
            serviceDateGrid.ItemsSource = list;
        }
    }
}
