﻿using System;
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

namespace TestApplicationWpf
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCopyToClipboard(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void BtnEditLock(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Test", "Test", MessageBoxButton.YesNoCancel);
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnCompileExecute(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Test", "Test", MessageBoxButton.YesNoCancel);
        }

        private void BtnExpand(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Test", "Test", MessageBoxButton.YesNoCancel);
        }
    }
}