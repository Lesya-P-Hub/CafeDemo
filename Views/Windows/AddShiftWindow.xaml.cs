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
    /// Логика взаимодействия для AddShiftWindow.xaml
    /// </summary>
    public partial class AddShiftWindow : Window
    {
        public AddShiftWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            EmployeeCmb.ItemsSource = App.GetContext().Employee.Where(emp => emp.RoleId != 1).ToList();
        }

        private void AddShiftBtn_Click(object sender, RoutedEventArgs e)
        {
            if(Convert.ToInt32(HoursAmountTb.Text) <= 4 && Convert.ToInt32(HoursAmountTb.Text) >= 16)
            {
                MessageBox.Show("Время для смены недопустимо!");
                return;
            }

            EmployeeShift employeeShift = new EmployeeShift()
            {
                Employee = EmployeeCmb.SelectedItem as Employee,
                Date = (DateTime)DateOfShiftDp.SelectedDate,
                HoursAmount = Convert.ToInt32(HoursAmountTb.Text)
            };

            App.GetContext().EmployeeShift.Add(employeeShift);
            App.GetContext().SaveChanges();
        }
    }
}
