using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MagicalGrocery.commands
{
    public class AddNewUser : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public event Action<Family, Address> AddUser;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {            
            var values = (object[])parameter;
            
            Family newfam = new Family();
            newfam.familyName = values[0].ToString();
            
            PasswordBox passwordBox = values[1] as PasswordBox;
            newfam.password = passwordBox.Password;

            newfam.registrationDate = DateTime.Now;
            //newfam.carts = null;

            Address newadd = new Address();
            newadd.city = values[2].ToString();
            newadd.street = values[3].ToString();
            newadd.number = Convert.ToInt32(values[4]);
            newadd.entery = values[5].ToString();
            newadd.floor = Convert.ToInt32(values[6]);

            AddUser(newfam, newadd);
            
        }
    }
}
