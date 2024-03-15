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
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void AuthorizeBtn_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = App.GetContext().Employee.FirstOrDefault(emp => emp.Login == LoginTb.Text && emp.Password == PasswordPb.Password);
            if (employee != null)
            {
                switch (employee.RoleId)
                {
                    case 1:
                        AdministratorWindow administratorWindow = new AdministratorWindow();
                        administratorWindow.Show();
                        break;
                    case 2:
                        WaiterWindow waiterWindow = new WaiterWindow();
                        waiterWindow.Show();
                        break;
                    case 3:
                        ChefWindow chefWindow = new ChefWindow();
                        chefWindow.Show();
                        break;
                }

                Close();
            }
            else
            {
                MessageBox.Show("Неправильно введён логин или пароль!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
