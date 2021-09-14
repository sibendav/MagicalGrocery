using BE;
using MagicalGrocery.commands;
using MagicalGrocery.controls;
using MagicalGrocery.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MagicalGrocery.ViewModel
{
    public class StoreVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public CartModel CurrentModel { get; set; }
        public addStore AddStore { get; set; }
        public Grid currentgrid { get; set; }

        public StoreVM(Grid gr, Family fam)
        {
            AddStore = new addStore();
            AddStore.AddStoreToBD += AddStore_AddStoreToBD;
            CurrentModel = new CartModel(gr, fam);
            currentgrid = gr;
        }

        private void AddStore_AddStoreToBD(BE.Store arg1, BE.Address arg2)
        {
            // adding the address
            arg2 = CurrentModel.addAddress(arg2);
            arg1.storeAddressId = arg2.addressId;

            // adding the Store
            CurrentModel.sto = arg1;
            CurrentModel.sto = CurrentModel.addStore();
           

            //adding the new cart
            CurrentModel.ca = new Cart() { familyId = CurrentModel.fam.familyId, storeId = CurrentModel.sto.storeId };
            Cart c = CurrentModel.addCart();

            //go to current shop UC
            currentShop cu = new currentShop(CurrentModel.ca, currentgrid);
            CurrentModel.thisGrid.Children.Clear();
            CurrentModel.thisGrid.Children.Add(cu);
        }
    }
}
