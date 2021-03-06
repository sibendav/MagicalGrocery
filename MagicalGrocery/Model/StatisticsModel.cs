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
        public List<ProductInCart> categorys { get; set; }

        public StatisticsModel(Family fam)
        {
            IBll bl = new imp_bll();
            MyFamily = fam;
            purchases = (from item in bl.returnAllCart()
                         where item.familyId == fam.familyId
                         select item).ToList<Cart>();
            categorys = (from item in bl.returnAllProductInCart()
                         where bl.returnCart(item.cartId).familyId == fam.familyId
                         select item).ToList<ProductInCart>();
        }
        public ObservableCollection<buyVM> GetBuyVM()
        {
            IBll bl = new imp_bll();
            var Result = purchases.GroupBy(item => new { item.paymentDate, item.storeId}).
                Select(item => new buyVM(item.Key.paymentDate, item.Key.storeId, MyFamily)).ToList();

            return new ObservableCollection<buyVM>(Result);
        }
        public ObservableCollection<buyVM> GetCatVM()
        {
            IBll bl = new imp_bll();
            var Result = categorys.GroupBy(item => new { bl.returnProduct(item.productId).category }).
                Select(item => new buyVM(item.Key.category, MyFamily)).ToList();

            return new ObservableCollection<buyVM>(Result);
        }
    }
}
