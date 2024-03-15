using CafeDemoLeontevaPetrova.Assets;
using CafeDemoLeontevaPetrova.Model;
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

namespace CafeDemoLeontevaPetrova.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddEmployeeWindow.xaml
    /// </summary>
    public partial class AddEmployeeWindow : Window
    {
        public AddEmployeeWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RoleCmb.ItemsSource = App.GetContext().Role.ToList();
        }

        private void AddEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            Employee newEmployee = new Employee()
            {
                Name= NameTb.Text,
                DateOfBirth = DateOfBirthDp.SelectedDate.Value,
                StatusId = 1,
                RoleId= Convert.ToInt32(RoleCmb.SelectedValue),
                Login = LoginTb.Text,
                Password = PasswordPb.Password
            };

            App.GetContext().Employee.Add(newEmployee);
            App.GetContext().SaveChanges();
            MessageBoxHelper.Information("Пользователь успешно добавлен!");
            DialogResult = true;
        }
    }
}
