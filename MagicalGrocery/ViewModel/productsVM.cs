using MagicalGrocery.commands;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalGrocery.ViewModel
{
    public class productsVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public addProductToDB addProduct { get; set; }

        public productsVM()
        {
            addProduct = new addProductToDB();
            addProduct.AddItem += AddProduct_AddItem;
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
                BLL.BLFactory.getBL().addToFirebase(path);
            }
        }
    }
}
