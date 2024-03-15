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
    /// Логика взаимодействия для AdministratorWindow.xaml
    /// </summary>
    public partial class AdministratorWindow : Window
    {
        public AdministratorWindow()
        {
            InitializeComponent();
        }

        private void EmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new Views.Pages.EmployeesPage());
        }

        private void ShiftBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new Views.Pages.ShiftsPage());
        }

        private void OrdersBtn_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
