﻿using BE;
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
    /// Interaction logic for SignUserControl.xaml
    /// </summary>
    public partial class SignUserControl : UserControl
    {
        public Family family = new Family();
        public Address address = new Address();

        public SignUserControl()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LogInWindow f = new LogInWindow();
            f.Show();
            Application.Current.Windows[0].Close();
        }
    }
}