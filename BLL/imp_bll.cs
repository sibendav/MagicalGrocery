using BE;
using DAL;
using Nest;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Device.Location;

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

        public async void addToFirebase(string path)
        {
            string dir = await firebase.addToFirebaseAsync(path);
            //while (dir == null) ;
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
                if (towich==null)
                {
                    QRcode qr = new QRcode();
                    qr.QRcodePicDir=dir;
                    qr.QRcodeString=value;

                    //GeoCoordinateWatcher watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.Default);
                    //watcher.Start(); //started watcher
                    //System.Device.Location.GeoCoordinate coord = watcher.Position.Location;
                    //qr.location = coord;

                    addQRcode(qr);
                    //adding the new product
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
