using BE;
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
    /// Interaction logic for storeUC.xaml
    /// </summary>
    public partial class storeUC : UserControl
    {
        public StoreVM thisVM { set; get; }

        public storeUC(Grid gr, Family fam)
        {
            thisVM = new StoreVM(gr, fam);
            this.DataContext = thisVM;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            currentShop c = new currentShop(thisVM.CurrentModel.ca);
            thisVM.CurrentModel.thisGrid.Children.Clear();
            thisVM.CurrentModel.thisGrid.Children.Add(c);
        }
    }
}
