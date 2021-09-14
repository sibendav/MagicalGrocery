using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MagicalGrocery.Model
{
    public class CartModel
    {
        public Cart ca { set; get; }
        public Store sto { set; get; }
        public Family fam { set; get; }
        public Grid thisGrid { set; get; }
        public List<Store> allStores  { set; get; }
        public List<Product> allProduct { set; get; }
        //{ 
        //    set { }
        //    get {
        //        return (from pro in BLL.BLFactory.getBL().returnAllProductInCart()
        //         where pro.cartId == ca.cartId
        //         select BLL.BLFactory.getBL().returnProduct(pro.productId)).ToList<Product>();
        //    } 
        //}


        public CartModel(Grid gr, Family fami)
        {            
            fam = fami;
            thisGrid = gr;
            allStores = BLL.BLFactory.getBL().returnAllStore();
        }
        public CartModel(Cart cart)
        {
            ca = cart;
            sto= BLL.BLFactory.getBL().returnStore(ca.storeId);
            fam= BLL.BLFactory.getBL().returnFamily(ca.familyId);
            allProduct = (from pro in BLL.BLFactory.getBL().returnAllProductInCart()
                          where pro.cartId==ca.cartId
                          select BLL.BLFactory.getBL().returnProduct(pro.productId)).ToList<Product>();
        }
        public Store addStore()
        {
            return BLL.BLFactory.getBL().addStore(sto);
        }

        public void addProduct(String path)
        {
            BLL.BLFactory.getBL().addToFirebase(path, ca);
            allProduct = (from pro in BLL.BLFactory.getBL().returnAllProductInCart()
                                       where pro.cartId == ca.cartId
                                       select BLL.BLFactory.getBL().returnProduct(pro.productId)).ToList<Product>();
        }

        public Cart addCart()
        {
            ca = BLL.BLFactory.getBL().addCart(ca);
            return ca;
        }
        public Cart updateCart()
        {
            ca.paymentDate = DateTime.Now;
            ca.status = true;
            ca = BLL.BLFactory.getBL().updateCart(ca);
            return ca;
        }
        public Address addAddress(Address ad)
        {
            return BLL.BLFactory.getBL().addAddress(ad);
        }
    }
}
