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
        public Grid currentgrid { get; set; }

        public storeUC(Grid gr, Family fam)
        {
            InitializeComponent();
            thisVM = new StoreVM(gr, fam);
            this.DataContext = thisVM;
            coboStore.ItemsSource = thisVM.CurrentModel.allStores;
            currentgrid = gr;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (coboStore.SelectedItem != null)
            {
                thisVM.CurrentModel.ca = new Cart() {paymentDate = DateTime.Now ,familyId=thisVM.CurrentModel.fam.familyId, storeId = ((Store)coboStore.SelectedItem).storeId };
                thisVM.CurrentModel.addCart();
                currentShop c = new currentShop(thisVM.CurrentModel.ca, currentgrid);
                thisVM.CurrentModel.thisGrid.Children.Clear();
                thisVM.CurrentModel.thisGrid.Children.Add(c);
            }
            else
            {
                MessageBox.Show("בחר חנות!");
            }
        }
    }
}
