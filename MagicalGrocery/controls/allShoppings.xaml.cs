using BE;
using MagicalGrocery.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for allShoppings.xaml
    /// </summary>
    public partial class allShoppings : UserControl, INotifyPropertyChanged
    {
        public profileVM CurrentVm { set; get; }
        
        public allShoppings(Family fam, Grid gr)
        {
            InitializeComponent();
            CurrentVm = new profileVM(fam, gr);
            this.DataContext = CurrentVm;

            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void allShops_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentShop c = new currentShop((Cart)allShops.SelectedItem);
            CurrentVm.currentModel.thisGrid.Children.Clear();
            CurrentVm.currentModel.thisGrid.Children.Add(c);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
