using CafeDemoLeontevaPetrova.Views.Windows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CafeDemoLeontevaPetrova.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для EmployeesPage.xaml
    /// </summary>
    public partial class EmployeesPage : Page
    {
        public EmployeesPage()
        {
            InitializeComponent();
            
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            EmployeesLv.ItemsSource = App.GetContext().Employee.ToList();
        }

        private void AddEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            AddEmployeeWindow addEmployeeWindow = new AddEmployeeWindow();
            if(addEmployeeWindow.ShowDialog() == true)
            {
                EmployeesLv.ItemsSource = App.GetContext().Employee.ToList();
            }
        }

        private void EmployeeStatusCmb_Initialized(object sender, EventArgs e)
        {
            ComboBox currentCmb = sender as ComboBox;
            currentCmb.ItemsSource = App.GetContext().EmployeeStatus.ToList();
        }
    }
}
