using NascarRaceManagment.AppData;
using NascarRaceManagment.Model;
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
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        private static NASCARRaceManagementDBEntities _context = App.GetContext();
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void TechSupprotBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CompanyInfoBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NewsBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void VideosBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GalleryBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ContactsBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AuthorisationBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthorisationWindow authorisationWindow = new AuthorisationWindow();
            authorisationWindow.Show();
            Close();
        }

        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            if (EmailTb.Text != "" && PasswordTB.Password != "" && LoginTB.Text != "")
            {
                    User newUser = new User()
                    {
                        RoleId = 2,
                        Email = EmailTb.Text,
                        Login = LoginTB.Text,
                        Password = PasswordTB.Password,
                    };
                    _context.User.Add(newUser);
                    _context.SaveChanges();
                    MessageBoxHelper.Information("Новый пользователь зарегистрирован.");
                    AuthorisationWindow authorisation = new AuthorisationWindow();
                    authorisation.ShowDialog();
                    Close();
            }
            else
            {
                MessageBoxHelper.Error("Не все поля для ввода были заполнены.");
            }
        }
    }
}
