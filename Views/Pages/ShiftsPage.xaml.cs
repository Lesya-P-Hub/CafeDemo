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
    /// Логика взаимодействия для ShiftsPage.xaml
    /// </summary>
    public partial class ShiftsPage : Page
    {
        public ShiftsPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ShiftsLv.ItemsSource = App.GetContext().EmployeeShift.ToList();
        }

        private void AddShiftBtn_Click(object sender, RoutedEventArgs e)
        {
            AddShiftWindow addShiftWindow = new AddShiftWindow();
            if(addShiftWindow.ShowDialog()==true)
            {
                ShiftsLv.ItemsSource = App.GetContext().EmployeeShift.ToList();
            }
        }
    }
}
