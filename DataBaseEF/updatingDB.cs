using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseEF
{
    public class updatingDB
    {
        public static Family updateFamily(Family var)
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var item = ctx.Families.Where(x => x.familyId == var.familyId).SingleOrDefault();
                    if (item != null)
                    {
                        ctx.Entry(item).CurrentValues.SetValues(var);
                        ctx.SaveChanges();
                    }
                    return item;

                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static Address updateAddress(Address var)
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var item = ctx.Addresses.Where(x => x.addressId == var.addressId).SingleOrDefault();
                    if (item != null)
                    {
                        ctx.Entry(item).CurrentValues.SetValues(var);
                        ctx.SaveChanges();
                    }
                    return item;

                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static Cart updateCart(Cart var)
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var item = ctx.Carts.Where(x => x.cartId == var.cartId).SingleOrDefault();
                    if (item != null)
                    {
                        ctx.Entry(item).CurrentValues.SetValues(var);
                        ctx.SaveChanges();
                    }
                    return item;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static Product updateProduct(Product var)
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var item = ctx.Products.Where(x => x.productId == var.productId).SingleOrDefault();
                    if (item != null)
                    {
                        ctx.Entry(item).CurrentValues.SetValues(var);
                        ctx.SaveChanges();
                    }
                    return item;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static ProductInCart updateProductInCart(ProductInCart var)
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var item = ctx.ProductInCarts.Where(x => x.ProductInCartId == var.ProductInCartId).SingleOrDefault();
                    if (item != null)
                    {
                        ctx.Entry(item).CurrentValues.SetValues(var);
                        ctx.SaveChanges();
                    }
                    return item;

                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static QRcode updateQRcode(QRcode var)
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var item = ctx.QRcodes.Where(x => x.qrcode == var.qrcode).SingleOrDefault();
                    if (item != null)
                    {
                        ctx.Entry(item).CurrentValues.SetValues(var);
                        ctx.SaveChanges();
                    }
                    return item;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static Store updateStore(Store var)
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var item = ctx.Stores.Where(x => x.storeId == var.storeId).SingleOrDefault();
                    if (item != null)
                    {
                        ctx.Entry(item).CurrentValues.SetValues(var);
                        ctx.SaveChanges();
                    }
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
