using BE;
using BLL;
using MagicalGrocery.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalGrocery.Model
{
    public class StatisticsModel
    {
        public Family MyFamily { get; set; }
        public List<Cart> purchases { get; set; }

        public StatisticsModel(Family fam)
        {
            IBll bl = new imp_bll();
            MyFamily = fam;
            purchases = (from item in bl.returnAllCart()
                         where item.familyId == fam.familyId
                         select item).ToList<Cart>();
        }
        public ObservableCollection<buyVM> GetBuyVM()
        {
            IBll bl = new imp_bll();
            var Result = purchases.GroupBy(item => new { item.paymentDate, item.storeId}).
                Select(item => new buyVM(item.Key.paymentDate, item.Key.storeId, MyFamily)).ToList();

            return new ObservableCollection<buyVM>(Result);
        }
    }
}
