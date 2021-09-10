using BLL;
using MagicalGrocery.commands;
using MagicalGrocery.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MagicalGrocery.ViewModel
{
    public class resignVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public AddNewUser addNewUserCommand { get; set; }

        public MainWinModel CurrentModel { get; set; }

        public resignVM()
        {
            addNewUserCommand = new AddNewUser();
            addNewUserCommand.AddUser += AddNewUserCommand_AddUser;

            CurrentModel = new MainWinModel();
        }

        private void AddNewUserCommand_AddUser(BE.Family obj, BE.Address obj2)
        {
            // adding the address
            obj2 = CurrentModel.AddAddress(obj2);
            obj.addressOfFamilyId = obj2.addressId;
            obj.address = obj2;

            // adding the Family
            obj = CurrentModel.AddFamily(obj);

            LogInWindow f = new LogInWindow(obj);
            f.Show();
            Application.Current.Windows[0].Close();
        }
    }
}
