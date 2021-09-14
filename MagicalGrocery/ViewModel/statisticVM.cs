using BE;
using MagicalGrocery.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalGrocery.ViewModel
{
    public class statisticVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public StatisticsModel currentModel { get; set; }
        public ObservableCollection<buyVM> shoppingVMs { get; set; }

        public statisticVM(Family fam)
        {
            this.currentModel = new StatisticsModel(fam);
            shoppingVMs = currentModel.GetBuyVM();
        }
    }
}
