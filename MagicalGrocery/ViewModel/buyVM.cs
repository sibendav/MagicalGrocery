using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalGrocery.ViewModel
{
    public class buyVM
    {
        public List<Cart> shopping { get; set; }

        public DateTime date { get; set; }

        public int numProducts
        {
            get { return shopping.Sum(item => item.numOfProducts); }
            private set { }
        }

        public double price
        {
            get { return shopping.Sum(item => item.sumToPay); }
            private set { }
        }

        public string storeName { get; set; }

        public string city { get; set; }

        public buyVM(DateTime _date, int store, Family fam)
        {
            IBll bl = new imp_bll();
            date = _date;
            Store s = bl.returnStore(store);
            storeName = s.storeName;
            city = bl.returnAddress(s.storeAddressId).city;
            shopping = (from item in bl.returnAllCart()
                        where item.familyId == fam.familyId && item.paymentDate == _date && item.storeId == store
                        select item).ToList<Cart>();
        }
    }
}
