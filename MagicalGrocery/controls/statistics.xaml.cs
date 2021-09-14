﻿using BE;
using MagicalGrocery.ViewModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MagicalGrocery.controls
{
    /// <summary>
    /// Interaction logic for statistics.xaml
    /// </summary>
    public partial class statistics : UserControl
    {
        public statisticVM currentVM { get; set; }
        public statistics(Family fam)
        {
            InitializeComponent();
            this.currentVM = new statisticVM(fam);
        }

        private void store_Click(object sender, RoutedEventArgs e)
        {
            //statGrid.Children.Clear();
            statGrid.Children.Add(new statByStore(currentVM.shoppingVMs));
        }
    }
}
