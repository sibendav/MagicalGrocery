using BE;
using DAL;
using Nest;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Device.Location;
using System.Windows;
using System.Globalization;
using static BE.Enum;
using Enum = BE.Enum;
using System.Threading.Tasks;

namespace BLL
{
    public class imp_bll : IBll
    {
        public Address addAddress(Address var)
        {
            return DALFactory.getDal().addAddress(var);
            //throw new NotImplementedException();
        }

        public Cart addCart(Cart var)
        {
            return DALFactory.getDal().addCart(var);
        }

        public Family addFamily(Family var)
        {
            return DALFactory.getDal().addFamily(var);
            //throw new NotImplementedException();
        }

        public Product addProduct(Product var)
        {
            return DALFactory.getDal().addProduct(var);
        }

        public ProductInCart addProductInCart(ProductInCart var)
        {
            return DALFactory.getDal().addProductInCart(var);
        }

        public QRcode addQRcode(QRcode var)
        {
            return DALFactory.getDal().addQRcode(var);
        }

        public Store addStore(Store var)
        {
            return DALFactory.getDal().addStore(var);
        }

        public async Task addToFirebase(string path, Cart c /*, int user, int cart*/)
        {
            string dir = await firebase.addToFirebaseAsync(path);
            
            string value = QRdecoder.showDetails(dir);
            if(value!=null)
            {
                var allQR = returnAllQRcode();
                QRcode towich;
                if (allQR == null)
                    towich = null;
                else
                {
                    towich = (from i in allQR
                              where i.QRcodeString == value
                              select i).FirstOrDefault();
                }
                if (towich == null)
                {
                    try {
                        QRcode qr = new QRcode();
                        qr.QRcodePicDir = dir;
                        qr.QRcodeString = value;

                        qr = addQRcode(qr);

                        
                        var proVal = value.Split(',');
                        CultureInfo cultures = new CultureInfo("en-US");
                        string enumVal = proVal[8];
                        BE.Enum.Categories cat = BE.Enum.Categories.Sale; ;
                        if (enumVal == " Food")
                            cat = BE.Enum.Categories.Food;
                        if (enumVal == " Sale")
                            cat = BE.Enum.Categories.Sale;
                        if (enumVal == " Drink")
                            cat = BE.Enum.Categories.Drink;
                        if (enumVal == " Clean")
                            cat = BE.Enum.Categories.Clean;
                        if (enumVal == " Pharma")
                            cat = BE.Enum.Categories.Pharma;
                        if (enumVal == " Clothing")
                            cat = BE.Enum.Categories.Clothing;
                        if (enumVal == " Electronics")
                            cat = BE.Enum.Categories.Electronics;
                        //   Sale, Food, Drink, Clean, Pharma, Clothing, Electronics
                        Product pro = addProduct(new Product
                        {
                            productName = proVal[0],
                            storeId = c.storeId,
                            productPrice = Convert.ToDouble(proVal[2]),
                            productPercentOff = Convert.ToDouble(proVal[3]),
                            productExpDate = Convert.ToDateTime(proVal[4], cultures),
                            productAmount = Convert.ToInt32(proVal[5]),
                            productPicDir = proVal[6],
                            productStock = Convert.ToInt32(proVal[7]),
                            category = cat
                        }) ;
                        if (pro == null)
                            throw new Exception("פריט לא תקין");
                        var proofcart = addProductInCart(new ProductInCart { cartId = c.cartId, productId = pro.productId, amount = 1, price = 1 * pro.productPrice, productQRcode = qr.qrcode });
                        if (proofcart == null)
                            throw new Exception("תקלת רשת");
                        var allProductInThisCart = (from i in returnAllProductInCart()
                                                    where i.cartId == c.cartId
                                                    select i);
                        c.numOfProducts = (from i in allProductInThisCart
                                           select i).Count();
                        c.sumToPay = (from i in allProductInThisCart
                                      select i.price).Sum();
                        var cart = updateCart(c);
                        MessageBox.Show("המוצר התווסף בהצלחה");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("אירע שגיאה !  " + e.Message);
                    }
                }
                else if (towich != null)
                {
                    string proName = value.Split(',')[0];
                    Product pro = (from p in returnAllProduct()
                                   where p.productName == proName
                                   select p).FirstOrDefault();
                    var o = addProductInCart(new ProductInCart { cartId = c.cartId, productId = pro.productId, amount = 1, price = 1 * pro.productPrice, productQRcode = towich.qrcode });
                    var allProductInThisCart = (from i in returnAllProductInCart()
                                                where i.cartId == c.cartId
                                                select i);
                    c.numOfProducts = (from i in allProductInThisCart
                                       select i).Count();
                    c.sumToPay = (from i in allProductInThisCart                                  
                                  select i.price).Sum();
                    var cart = updateCart(c);
                    MessageBox.Show("המוצר התווסף בהצלחה");
                }
            }
        }
        
        public bool deleteAddress(Address var)
        {
            throw new NotImplementedException();
        }

        public bool deleteCart(Cart var)
        {
            throw new NotImplementedException();
        }

        public bool deleteFamily(Family var)
        {
            throw new NotImplementedException();
        }

        public bool deleteProduct(Product var)
        {
            throw new NotImplementedException();
        }

        public bool deleteProductInCart(ProductInCart var)
        {
            throw new NotImplementedException();
        }

        public bool deleteQRcode(QRcode var)
        {
            throw new NotImplementedException();
        }

        public bool deleteStore(Store var)
        {
            throw new NotImplementedException();
        }

        public Address returnAddress(int var)
        {
            return DALFactory.getDal().returnAddress(var);
        }

        public List<Address> returnAllAddress()
        {
            return DALFactory.getDal().returnAllAddress();
        }

        public List<Cart> returnAllCart()
        {
            return DALFactory.getDal().returnAllCart();
        }

        public List<Family> returnAllFamily()
        {
            return DALFactory.getDal().returnAllFamily();
        }

        public List<Cart> returnAllOfFamilyCart(int var)
        {
            var allcarts = returnAllCart();
            var carts = (from i in allcarts
                         where i.familyId == var
                         select i).ToList<Cart>();
            return carts;
        }

        public List<Product> returnAllProduct()
        {
            return DALFactory.getDal().returnAllProduct();
        }

        public List<ProductInCart> returnAllProductInCart()
        {
            return DALFactory.getDal().returnAllProductInCart();
        }

        public List<Cart> returnAllProductsInCart(int var)
        {
            throw new NotImplementedException();
        }

        public List<QRcode> returnAllQRcode()
        {
            return DALFactory.getDal().returnAllQRcode();
        }

        public List<Store> returnAllStore()
        {
            return DALFactory.getDal().returnAllStore();
        }

        public Cart returnCart(int var)
        {
            return DALFactory.getDal().returnCart(var);
        }

        public Family returnFamily(int var)
        {
            return DALFactory.getDal().returnFamily(var);
        }

        public Product returnProduct(int var)
        {
            return DALFactory.getDal().returnProduct(var);
        }

        public ProductInCart returnProductInCart(int var)
        {
            return DALFactory.getDal().returnProductInCart(var);
        }

        public QRcode returnQRcode(int var)
        {
            return DALFactory.getDal().returnQRcode(var);
        }

        public Store returnStore(int var)
        {
            return DALFactory.getDal().returnStore(var);
        }

        public Address updateAddress(Address var)
        {
            return DALFactory.getDal().updateAddress(var);
        }

        public Cart updateCart(Cart var)
        {
            return DALFactory.getDal().updateCart(var);
        }

        public Family updateFamily(Family var)
        {
            return DALFactory.getDal().updateFamily(var);
        }

        public Product updateProduct(Product var)
        {
            return DALFactory.getDal().updateProduct(var);
        }

        public ProductInCart updateProductInCart(ProductInCart var)
        {
            return DALFactory.getDal().updateProductInCart(var);
        }

        public QRcode updateQRcode(QRcode var)
        {
            return DALFactory.getDal().updateQRcode(var);
        }

        public Store updateStore(Store var)
        {
            return DALFactory.getDal().updateStore(var);
        }
    }
}
