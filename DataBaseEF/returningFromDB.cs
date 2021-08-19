using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseEF
{
    public class returningFromDB
    {
        public static Family returnFamily(int var)
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var item = ctx.Families.Where(x => x.familyId == var).SingleOrDefault();
                    return item;

                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static Address returnAddress(int var)
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var item = ctx.Addresses.Where(x => x.addressId == var).SingleOrDefault();
                    return item;

                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static Cart returnCart(int var)
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var item = ctx.Carts.Where(x => x.cartId == var).SingleOrDefault();
                    return item;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static Product returnProduct(int var)
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var item = ctx.Products.Where(x => x.productId == var).SingleOrDefault();
                    return item;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static ProductInCart returnProductInCart(int var)
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var item = ctx.ProductInCarts.Where(x => x.ProductInCartId == var).SingleOrDefault();
                    return item;

                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static QRcode returnQRcode(int var)
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var item = ctx.QRcodes.Where(x => x.qrcode == var).SingleOrDefault();
                    return item;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static Store returnStore(int var)
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var item = ctx.Stores.Where(x => x.storeId == var).SingleOrDefault();
                    return item;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
