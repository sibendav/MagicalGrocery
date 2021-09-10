using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MagicalGrocery.commands
{
    public class addStore : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public event Action<Store, Address> AddStoreToBD;
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var values = (object[])parameter;

            Store newVar = new Store();
            newVar.storeName = values[0].ToString();

            Address newadd = new Address();
            newadd.city = values[1].ToString();
            newadd.street = values[2].ToString();
            newadd.number = Convert.ToInt32(values[3]);
            newadd.entery = values[4].ToString();
            newadd.floor = Convert.ToInt32(values[5]);

            AddStoreToBD(newVar, newadd);
        }
    }
}
