using NascarRaceManagment.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace NascarRaceManagment
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static NASCARRaceManagementDBEntities _context;
        public static NASCARRaceManagementDBEntities GetContext() 
        {
            if (_context == null)
            {
                _context = new NASCARRaceManagementDBEntities();
            }
            return _context;
        }
    }
}
