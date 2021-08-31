using MagicalGrocery.commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
            //Checking if the password is ok
            var user = (from i in BLL.BLFactory.getBL().returnAllFamily()
                        where i.familyName == arg1
                        select i).FirstOrDefault();
            if(user == null)
            {
                MessageBox.Show("המשתמש לא קיים במערכת! הירשם לשירות!");
                return;
            }
            if(user.password != arg2)
            {
                MessageBox.Show("סיסמא לא תקינה!");
                return;
            }
            LogInWindow f = new LogInWindow(user);
            f.Show();
            System.Windows.Application.Current.Windows[0].Close();
        }
    }
}
