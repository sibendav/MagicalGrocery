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
    /// Interaction logic for UserTitle.xaml
    /// </summary>
    public partial class UserTitle : UserControl
    {
        public userTitleVM currentVM;
        public UserTitle()
        {
            InitializeComponent();
            currentVM = new userTitleVM();
            this.DataContext = currentVM;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Windows[0].Hide();           
        }
    }
}
