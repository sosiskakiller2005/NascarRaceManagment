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
    /// Логика взаимодействия для AuthorisationWindow.xaml
    /// </summary>
    public partial class AuthorisationWindow : Window
    {
        public AuthorisationWindow()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            Close();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTB.Text != "" && PasswordTB.Password != null)
            {
                if (AuthorisationHelper.Authorise(LoginTB.Text, PasswordTB.Password) == true)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    Close();
                }
            }
            else
            {
                MessageBoxHelper.Error("Не все поля для ввода были заполнены.");
            }
        }

        private void GalleryBTn_Click(object sender, RoutedEventArgs e)
        {
            GalleryWindow galleryWindow = new GalleryWindow();
            galleryWindow.Show();
        }

        private void RecoverPasswordHl_Click(object sender, RoutedEventArgs e)
        {
            RecoverPasswordWindow recoverPasswordWindow = new RecoverPasswordWindow();
            recoverPasswordWindow.ShowDialog();
        }
    }
}
