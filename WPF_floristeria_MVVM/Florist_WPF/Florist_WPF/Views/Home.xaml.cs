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
using Florist_WPF.Views;

namespace Florist_WPF
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void AddProductsButton_Click(object sender, RoutedEventArgs e)
        {
            AddProducts addProd = new AddProducts();
            this.NavigationService.Navigate(addProd);
        }
    }

    //private void AddProductsButton_Click(object sender, RoutedEventArgs e)
    //{
    //    var window = new AddProducts();
    //    this.Content = window;
    //}
}
