using BE;
using DevExpress.Utils.CommonDialogs.Internal;
using MagicalGrocery.ViewModel;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for currentShop.xaml
    /// </summary>
    public partial class currentShop : UserControl, INotifyPropertyChanged
    {
        public productsVM currentVM { set; get; }
        

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public currentShop(Cart currentCart)
        {
            InitializeComponent();
            currentVM = new productsVM(currentCart);
            this.DataContext = currentVM;
            lblStore.Content = lblStore.Content + " " + currentVM.currentModel.sto.storeName;
            if (currentCart.status == true)
            {
                btnFinish.Visibility = Visibility.Collapsed;
                btnAdd.Visibility = Visibility.Collapsed;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\Users\simha\source\repos\MagicalGrocery\MagicalGrocery\images";
            openFileDialog1.Filter = "Document Files|*.txt|Pictures Files|*.jpeg;*.jpg;*.png|All Files(*.*)|*.*"; ;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == true)
            {
                var path = openFileDialog1.FileName;
                var upProd = ((Product)allProds.SelectedItem);
                upProd.productPicDir = path;
                BLL.BLFactory.getBL().updateProduct(upProd);
                allProds.ItemsSource = currentVM.ProVMs;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            currentVM.currentModel.updateCart();
            btnFinish.Visibility = Visibility.Collapsed;
            btnAdd.Visibility = Visibility.Collapsed;
        }
    }
}
