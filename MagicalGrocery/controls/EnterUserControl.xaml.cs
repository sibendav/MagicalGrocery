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
    /// Interaction logic for EnterUserControl.xaml
    /// </summary>
    public partial class EnterUserControl : UserControl
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public EnterUserControl()
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
