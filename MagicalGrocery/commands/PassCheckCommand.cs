using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MagicalGrocery.commands
{
    public class PassCheckCommand : ICommand
    {
        public event Action<string, string> checkInUser;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var values = (object[])parameter;
            string userName = values[0].ToString();
            string Pass = values[1].ToString();
            checkInUser(userName, Pass);
        }
    }
}
