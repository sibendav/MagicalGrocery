using BE;
using MagicalGrocery.commands;
using MagicalGrocery.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MagicalGrocery.ViewModel
{
    public class profileVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public profileModel currentModel { set; get; }
        public updateUserCommand updateUser { set; get; }

        public ObservableCollection<Cart> CartVMs { get; set; }

        public profileVM(Family fam, Grid gr)
        {
            updateUser = new updateUserCommand();
            updateUser.updateUser += UpdateUser_updateUser;
            this.currentModel = new profileModel(fam, gr);
            foreach (Cart i in currentModel.carts)
            {
                i.store = BLL.BLFactory.getBL().returnStore(i.storeId);
            }
            CartVMs = new ObservableCollection<Cart>(currentModel.carts);
        }

        private void UpdateUser_updateUser()
        {
            Family fam = currentModel.updateFamily();
            Address add = currentModel.updateAddress();
            if (fam != null && add != null)
                MessageBox.Show("עודכן במאגר בהצלחה!");
            else
                MessageBox.Show("אירע שגיאה");
        }
    }
}
