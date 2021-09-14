using BE;
using MagicalGrocery.commands;
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

namespace MagicalGrocery.ViewModel
{
    public class productsVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public CartModel currentModel { get; set; }
        public addProductToDB addProduct { get; set; }
        public ObservableCollection<Product> ProVMs { get; set; }


        public productsVM(Cart cart)
        {
            currentModel = new CartModel(cart);
            addProduct = new addProductToDB();
            addProduct.AddItem += AddProduct_AddItem;
            foreach (Product i in currentModel.allProduct)
            {
                i.store = BLL.BLFactory.getBL().returnStore(i.storeId);
            }
            ProVMs = new ObservableCollection<Product>(currentModel.allProduct);
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
                currentModel.addProduct(path);
                ProVMs = new ObservableCollection<Product>(currentModel.allProduct);
            }
            
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
