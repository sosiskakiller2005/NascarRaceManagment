using NascarRaceManagment.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static NASCARRaceManagementDBEntities _context = App.GetContext();
        List<Race> races = _context.Race.ToList();
        public MainWindow()
        {
            InitializeComponent();
            //List<string> months = new List<string> {"Все месяцы", "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            //MonthSortCmb.ItemsSource = months;
            //MonthSortCmb.SelectedIndex = 0;
            //List<Track> tracks = _context.Track.ToList();
            //tracks.Insert(0, new Track() { Name = "Все треки" });
            //TrackSortCmb.ItemsSource = tracks;
            //TrackSortCmb.DisplayMemberPath = "Name";
            //TrackSortCmb.SelectedIndex = 0;
            RacesLV.ItemsSource = races;
        }

        private void RacesLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        //private void Update()
        //{
        //    races = _context.Race.ToList();
        //    if (TrackSortCmb.SelectedIndex != 0)
        //    {
        //        if (MonthSortCmb.SelectedIndex != 0)
        //        {
        //            races = races.Where(r => r.Track == TrackSortCmb.SelectedItem as Track && r.DateTime.Month == MonthSortCmb.SelectedIndex).ToList();
        //        }
        //        else
        //        {
        //            races = races.Where(r => r.Track == TrackSortCmb.SelectedItem as Track).ToList();
        //        }
        //    }
        //    else
        //    {
        //        if (MonthSortCmb.SelectedIndex != 0)
        //        {
        //            races = races.Where(r => r.DateTime.Month == MonthSortCmb.SelectedIndex).ToList();

        //        }
        //        else
        //        {
        //            races = _context.Race.ToList();

        //        }
        //    }
        //    RacesLV.ItemsSource = races;
        //}

        private void AllRacesBtn_Click(object sender, RoutedEventArgs e)
        {
            races = _context.Race.ToList();
            RacesLV.ItemsSource = races;
        }

        private void JanauryBtn_Click(object sender, RoutedEventArgs e)
        {
            races = _context.Race.Where(r => r.DateTime.Month == 1).ToList();
            RacesLV.ItemsSource = races;
        }

        private void FebruaryBtn_Click(object sender, RoutedEventArgs e)
        {
            races = _context.Race.Where(r => r.DateTime.Month == 2).ToList();
            RacesLV.ItemsSource = races;
        }

        private void MarchBtn_Click(object sender, RoutedEventArgs e)
        {
            races = _context.Race.Where(r => r.DateTime.Month == 3).ToList();
            RacesLV.ItemsSource = races;
        }

        private void AprilBtn_Click(object sender, RoutedEventArgs e)
        {
            races = _context.Race.Where(r => r.DateTime.Month == 4).ToList();
            RacesLV.ItemsSource = races;
        }

        private void MayBtn_Click(object sender, RoutedEventArgs e)
        {
            races = _context.Race.Where(r => r.DateTime.Month == 5).ToList();
            RacesLV.ItemsSource = races;
        }

        private void JuneBtn_Click(object sender, RoutedEventArgs e)
        {
            races = _context.Race.Where(r => r.DateTime.Month == 6).ToList();
            RacesLV.ItemsSource = races;
        }

        private void JulyBtn_Click(object sender, RoutedEventArgs e)
        {
            races = _context.Race.Where(r => r.DateTime.Month == 7).ToList();
            RacesLV.ItemsSource = races;
        }

        private void AugustBtn_Click(object sender, RoutedEventArgs e)
        {
            races = _context.Race.Where(r => r.DateTime.Month == 8).ToList();
            RacesLV.ItemsSource = races;
        }

        private void SeptemberBtn_Click(object sender, RoutedEventArgs e)
        {
            races = _context.Race.Where(r => r.DateTime.Month == 9).ToList();
            RacesLV.ItemsSource = races;
        }

        private void OctoberBtn_Click(object sender, RoutedEventArgs e)
        {
            races = _context.Race.Where(r => r.DateTime.Month == 10).ToList();
            RacesLV.ItemsSource = races;
        }

        private void NovemberBtn_Click(object sender, RoutedEventArgs e)
        {
            races = _context.Race.Where(r => r.DateTime.Month == 11).ToList();
            RacesLV.ItemsSource = races;
        }

        private void DecemberBtn_Click(object sender, RoutedEventArgs e)
        {
            races = _context.Race.Where(r => r.DateTime.Month == 12).ToList();
            RacesLV.ItemsSource = races;
        }

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scrollviewer = sender as ScrollViewer;
            if (e.Delta > 0)
            {
                scrollviewer.LineLeft();
                scrollviewer.LineLeft();
                scrollviewer.LineLeft();
                scrollviewer.LineLeft();
                scrollviewer.LineLeft();
                scrollviewer.LineLeft();
                
            }
            else
            {
                scrollviewer.LineRight();
                scrollviewer.LineRight();
                scrollviewer.LineRight();
                scrollviewer.LineRight();
                scrollviewer.LineRight();
                scrollviewer.LineRight();
            }
            e.Handled = true;
        }
    }
}
