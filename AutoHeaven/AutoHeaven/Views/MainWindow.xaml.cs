using AutoHeaven.Extentions;
using AutoHeaven.Model;
using AutoHeaven.Views;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace AutoHeaven
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(userLogin.Text))
            {
                MessageBox.Show("Введите логин", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (String.IsNullOrWhiteSpace(userPassword.Password))
            {
                MessageBox.Show("Введите пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (userLogin.Text == "DEMO" && userPassword.Password == "DEMO")
            {
                MessageBox.Show("Выполнен вход в режиме ДЕМО", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                DemoWindow demoWindow = new DemoWindow();
                demoWindow.Show();
                this.Close();
                return;
            }

            Personal user = AutoHeavenEntities.GetContext().Personal
                .FirstOrDefault(per => per.PersonalLogin == userLogin.Text && per.PersonalPassword == userPassword.Password);

            if (user == null)
            {
                MessageBox.Show("Логин или пароль не верный", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            MessageBox.Show($"Вы вошли как {user.LastName} {user.FirstName[0]}.{user.MiddleName[0]}.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            OutputWindow outputWindow = new OutputWindow(user);
            outputWindow.Show();
            Close();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                enterButton.PerformClick();
        }
    }
}
