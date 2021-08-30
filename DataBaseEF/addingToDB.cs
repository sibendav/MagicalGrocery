using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseEF
{
    public class addingToDB
    {
        public static Family addFamily(Family var)
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    //var fam = new Family() { familyName = "cohen", password = "1234", registrationDate = DateTime.Now };
                    var fam = new Family() { familyName = var.familyName, addressOfFamilyId=var.addressOfFamilyId, password = var.password, registrationDate = DateTime.Now/*, address=var.address*/ };
                    ctx.Families.Add(fam);
                    ctx.SaveChanges();
                    return fam;

                }
            }
            catch(Exception e)
            {
                return null;
            }
        }
        public static Address addAddress(Address var)
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var add = new Address() { city = var.city, entery = var.entery, street = var.street, number=var.number, floor=var.floor };
                    ctx.Addresses.Add(add);
                    ctx.SaveChanges();
                    return add;

                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static Cart addCart(Cart var)
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var cart = new Cart() { familyId = var.familyId, numOfProducts = var.numOfProducts, paymentDate = var.paymentDate, status = var.status, sumToPay = var.sumToPay };
                    ctx.Carts.Add(cart);
                    ctx.SaveChanges();
                    return cart;

                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static Product addProduct(Product var)
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var product = new Product() { category = var.category, productAmount = var.productAmount, productName = var.productName, productPercentOff = var.productPercentOff, productExpDate = var.productExpDate, productPicDir=var.productPicDir, productPrice=var.productPrice, productStock=var.productStock, storeId=var.storeId };
                    ctx.Products.Add(product);
                    ctx.SaveChanges();
                    return product;

                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static ProductInCart addProductInCart(ProductInCart var)
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var productInCart = new ProductInCart() { amount = var.amount, cartId = var.cartId, price = var.price, productId = var.productId, productQRcode = var.productQRcode };
                    ctx.ProductInCarts.Add(productInCart);
                    ctx.SaveChanges();
                    return productInCart;

                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static QRcode addQRcode(QRcode var)
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var qrCode = new QRcode() {  QRcodePicDir = var.QRcodePicDir, time = DateTime.Now, QRcodeString=var.QRcodeString};
                    ctx.QRcodes.Add(qrCode);
                    ctx.SaveChanges();
                    return qrCode;

                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static Store addStore(Store var)
        {
            try
            {
                using (var ctx = new MyGrocery())
                {
                    var store = new Store() { storeName = var.storeName, storeAddressId = var.storeAddressId};
                    ctx.Stores.Add(store);
                    ctx.SaveChanges();
                    return store;

                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
