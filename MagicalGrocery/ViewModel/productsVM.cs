using BE;
using MagicalGrocery.commands;
using MagicalGrocery.controls;
using MagicalGrocery.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MagicalGrocery.ViewModel
{
    public class productsVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public CartModel currentModel { get; set; }
        public addProductToDB addProduct { get; set; }
        public updateProduct upProduct { get; set; }
        public ObservableCollection<Product> ProVMs { get; set; }
        public Grid currentgrid { get; set; }
        public Cart currentCart { get; set; }


        public productsVM(Cart cart, Grid gr)
        {
            currentModel = new CartModel(cart, gr);
            addProduct = new addProductToDB();
            addProduct.AddItem += AddProduct_AddItem;

            upProduct = new updateProduct();
            upProduct.AddItem += UpProduct_AddItem;

            foreach (Product i in currentModel.allProduct)
            {
                i.store = BLL.BLFactory.getBL().returnStore(i.storeId);
            }
            ProVMs = new ObservableCollection<Product>(currentModel.allProduct);
            currentgrid = gr;
            this.currentCart = cart;
        }

        private void UpProduct_AddItem(Product p)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\Users\simha\source\repos\MagicalGrocery\MagicalGrocery\images";
            openFileDialog1.Filter = "Document Files|*.txt|Pictures Files|*.jpeg;*.jpg;*.png|All Files(*.*)|*.*"; ;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == true)
            {
                var path = openFileDialog1.FileName;
                var upProd = p;
                upProd.productPicDir = path;
                BLL.BLFactory.getBL().updateProduct(upProd);
                
            }
        }

        private void AddProduct_AddItem()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\Users\simha\source\repos\MagicalGrocery\MagicalGrocery\images";
            openFileDialog1.Filter = "Document Files|*.txt|Pictures Files|*.jpeg;*.jpg;*.png|All Files(*.*)|*.*"; ;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == true)
            {
                var path = openFileDialog1.FileName;
                currentModel.addProductAsync(path);
                //ProVMs = new ObservableCollection<Product>(currentModel.allProduct);
            }
            currentgrid.Children.Clear();
            currentgrid.Children.Add(new currentShop(currentCart, currentgrid));

        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
