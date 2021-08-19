using MagicalGrocery.controls;
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

namespace MagicalGrocery
{
    /// <summary>
    /// Interaction logic for LogInWindow.xaml
    /// </summary>
    public partial class LogInWindow : Window
    {
        public LogInWindow(string famName)
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            profile p = new profile();
            p.HorizontalAlignment = HorizontalAlignment.Center;
            p.VerticalAlignment = VerticalAlignment.Center;
            mainGrid.Children.Clear();
            mainGrid.Children.Add(p);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            allShoppings p = new allShoppings();
            p.HorizontalAlignment = HorizontalAlignment.Center;
            p.VerticalAlignment = VerticalAlignment.Center;
            mainGrid.Children.Clear();
            mainGrid.Children.Add(p);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            statistics p = new statistics();
            p.HorizontalAlignment = HorizontalAlignment.Center;
            p.VerticalAlignment = VerticalAlignment.Center;
            mainGrid.Children.Clear();
            mainGrid.Children.Add(p);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            recommendation p = new recommendation();
            p.HorizontalAlignment = HorizontalAlignment.Center;
            p.VerticalAlignment = VerticalAlignment.Center;
            mainGrid.Children.Clear();
            mainGrid.Children.Add(p);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            currentShop p = new currentShop();
            p.HorizontalAlignment = HorizontalAlignment.Center;
            p.VerticalAlignment = VerticalAlignment.Center;
            mainGrid.Children.Clear();
            mainGrid.Children.Add(p);
        }
    }
}
