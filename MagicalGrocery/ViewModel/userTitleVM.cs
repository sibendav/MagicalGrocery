using MagicalGrocery.commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalGrocery.ViewModel
{
    public class userTitleVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public dispossUser disCmd { get; set; }

        public userTitleVM()
        {
            disCmd = new dispossUser();

        }
    }
}
