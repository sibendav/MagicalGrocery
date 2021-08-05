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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MagicalGrocery
{
    /// <summary>
    /// Interaction logic for BasicTitle.xaml
    /// </summary>
    public partial class BasicTitle : UserControl
    {
        public BasicTitle()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EnterUserControl enterUser = new EnterUserControl();
            enterUser.HorizontalAlignment = HorizontalAlignment.Center;
            enterUser.VerticalAlignment = VerticalAlignment.Center;
            mainGrid.Children.Clear();
            mainGrid.Children.Add(enterUser);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SignUserControl enterUser = new SignUserControl();
            enterUser.HorizontalAlignment = HorizontalAlignment.Center;
            enterUser.VerticalAlignment = VerticalAlignment.Center;
            mainGrid.Children.Clear();
            mainGrid.Children.Add(enterUser);
        }
    }
}
