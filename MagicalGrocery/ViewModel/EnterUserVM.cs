using MagicalGrocery.commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MagicalGrocery.ViewModel
{
    public class EnterUserVM: INotifyPropertyChanged
    {
        public PassCheckCommand checkUser { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public EnterUserVM()
        {
            checkUser = new PassCheckCommand();
            checkUser.checkInUser += CheckUser_checkInUser; ;
        }

        private void CheckUser_checkInUser(string arg1, string arg2)
        {
            // TODO
            //Checking if the password is ok
            LogInWindow f = new LogInWindow(arg1);
            f.Show();
        }
    }
}
