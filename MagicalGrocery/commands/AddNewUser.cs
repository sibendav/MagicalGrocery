using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            newfam.password = values[1].ToString();
            newfam.registrationDate = DateTime.Now;
            //newfam.carts = null;

            Address newadd = new Address();
            newadd.city = values[2].ToString();
            newadd.street = values[3].ToString();
            newadd.number = Convert.ToInt32(values[4]);
            newadd.entery = values[5].ToString();
            newadd.floor = Convert.ToInt32(values[6]);

            AddUser(newfam, newadd);
            LogInWindow f = new LogInWindow(newfam.familyName);
            f.Show();            
        }
    }
}
