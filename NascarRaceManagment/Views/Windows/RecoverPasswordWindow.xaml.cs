using NascarRaceManagment.AppData;
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

namespace NascarRaceManagment.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для RecoverPasswordWindow.xaml
    /// </summary>
    public partial class RecoverPasswordWindow : Window
    {
        public RecoverPasswordWindow()
        {
            InitializeComponent();
        }

        private void SendBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxHelper.Information("Письмо для восстановления пароля отправлено.");
            Close();
        }
    }
}
