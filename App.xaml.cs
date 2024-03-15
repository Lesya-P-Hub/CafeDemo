using CafeDemoLeontevaPetrova.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CafeDemoLeontevaPetrova
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        static CafeEntities context;


        public static CafeEntities GetContext()
        {
            if (context == null)
            {
                context = new CafeEntities();
            }
            return context;
        }
       
    }
}
