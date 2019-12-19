using MoodTracker2._0;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Menushka
{
    /// <summary>
    /// Логика взаимодействия для Choose.xaml
    /// </summary>
    public partial class Choose : Window
    {
        public Choose()
        {
            InitializeComponent();
        }

        private void MoodTrackerClick(object sender, RoutedEventArgs e)
        {
            MoodTracker2._0.MainWindow window = new MoodTracker2._0.MainWindow();
            window.Show();
        }

        private void OnCloseChooseClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void TODOClick(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MoodToday();
            window.Show();
        }
    }
}
