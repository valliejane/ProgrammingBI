﻿using System;
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

namespace MoodTracker2._0
{
    /// <summary>
    /// Логика взаимодействия для MoodToday.xaml
    /// </summary>
    public partial class MoodToday : Window
    {
        public MoodToday()
        {
            InitializeComponent();
        }

        private void OnBadClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void OnNeutralClick(object sender, RoutedEventArgs e)
        {

        }

        private void OnGoodClick(object sender, RoutedEventArgs e)
        {

        }

        private void OnCloseClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
