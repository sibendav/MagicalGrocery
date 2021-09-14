using MagicalGrocery.ViewModel;
using MagicalGrocery.Converters;
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
        private EnterUserVM CurrentVm;
        public Grid MyGrid { get; set; }
        public EnterUserControl(Grid thisGrid)
        {
            InitializeComponent();
            CurrentVm = new EnterUserVM();
            this.DataContext = CurrentVm;
            MyGrid = thisGrid;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyGrid.Children.Clear();
            MyGrid.Children.Add(new SignUserControl());
        }
    }
}
