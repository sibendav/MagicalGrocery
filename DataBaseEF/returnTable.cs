using BE;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseEF
{
    public class returnTable
    {
        public static List<Family> returnFamily()
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var item = (from i in ctx.Families
                                select i).ToList<Family>();
                    return item;

                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static List<Address> returnAddress()
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var item = (from i in ctx.Addresses
                                select i).ToList<Address>();
                     
                    return item;

                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static List<Cart> returnCart()
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var item = (from i in ctx.Carts
                                select i).ToList<Cart>();
                    return item;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static List<Product> returnProduct()
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var item = (from i in ctx.Products
                                select i).ToList<Product>();
                    return item;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static List<ProductInCart> returnProductInCart()
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var item = (from i in ctx.ProductInCarts
                                select i).ToList<ProductInCart>();                       
                    return item;

                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static List<QRcode> returnQRcode()
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    if (ctx.QRcodes == null)
                        return null;
                    var item = (from r in ctx.QRcodes select r).ToList<QRcode>();
                    return item;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static List<Store> returnAllStore()
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var items = (from i in ctx.Stores
                                 select i).ToList<Store>();
                    return items;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
