﻿using System.Windows;

namespace Hospital
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();





        }

        //private void roomOptions(object sender, RoutedEventArgs e)
        //{
        //    RoomOptions room = new RoomOptions();
        //    room.Show();
        //}

        private void Button_Click_Patient(object sender, RoutedEventArgs e)
        {
            //var new_window = new Pacijent();
            //new_window.Show();
            //App.Current.MainWindow.Hide();


        }

        private void Button_Click_Doctor(object sender, RoutedEventArgs e)
        {
            DoctorWindow doctorWindow = new DoctorWindow();
            doctorWindow.Show();
            App.Current.MainWindow.Hide();
        }

        private void Button_Click_Director(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Secretary(object sender, RoutedEventArgs e)
        {

        }
    }
}
