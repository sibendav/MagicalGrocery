using BE;
using DataBaseEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Dal_imp : IDal
    {
        public Address addAddress(Address var)
        {
            return DataBaseEF.addingToDB.addAddress(var);
        }

        public Cart addCart(Cart var)
        {
            return DataBaseEF.addingToDB.addCart(var);
        }

        public Family addFamily(Family var)
        {
            return DataBaseEF.addingToDB.addFamily(var);
        }

        public Product addProduct(Product var)
        {
            return DataBaseEF.addingToDB.addProduct(var);
        }

        public ProductInCart addProductInCart(ProductInCart var)
        {
            return DataBaseEF.addingToDB.addProductInCart(var);
        }

        public QRcode addQRcode(QRcode var)
        {
            return DataBaseEF.addingToDB.addQRcode(var);
        }

        public Store addStore(Store var)
        {
            return DataBaseEF.addingToDB.addStore(var);
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
            return DataBaseEF.returningFromDB.returnAddress(var);
        }

        public List<Address> returnAllAddress()
        {
            return DataBaseEF.returnTable.returnAddress();
        }

        public List<Cart> returnAllCart()
        {
            return DataBaseEF.returnTable.returnCart();
        }

        public List<Family> returnAllFamily()
        {
            return DataBaseEF.returnTable.returnFamily();
        }

        public List<Product> returnAllProduct()
        {
            return DataBaseEF.returnTable.returnProduct();
        }

        public List<ProductInCart> returnAllProductInCart()
        {
            return DataBaseEF.returnTable.returnProductInCart();
        }

        public List<QRcode> returnAllQRcode()
        {
            return DataBaseEF.returnTable.returnQRcode();
        }

        public List<Store> returnAllStore()
        {
            return DataBaseEF.returnTable.returnAllStore();
        }

        public Cart returnCart(int var)
        {
            return DataBaseEF.returningFromDB.returnCart(var);
        }

        public Family returnFamily(int var)
        {
            return DataBaseEF.returningFromDB.returnFamily(var);
        }

        public Product returnProduct(int var)
        {
            return DataBaseEF.returningFromDB.returnProduct(var);
        }

        public ProductInCart returnProductInCart(int var)
        {
            return DataBaseEF.returningFromDB.returnProductInCart(var);
        }

        public QRcode returnQRcode(int var)
        {
            return DataBaseEF.returningFromDB.returnQRcode(var);
        }

        public Store returnStore(int var)
        {
            return DataBaseEF.returningFromDB.returnStore(var);
        }

        public Address updateAddress(Address var)
        {
            return DataBaseEF.updatingDB.updateAddress(var);
        }

        public Cart updateCart(Cart var)
        {
            return DataBaseEF.updatingDB.updateCart(var);
        }

        public Family updateFamily(Family var)
        {
            return DataBaseEF.updatingDB.updateFamily(var);
        }

        public Product updateProduct(Product var)
        {
            return DataBaseEF.updatingDB.updateProduct(var);
        }

        public ProductInCart updateProductInCart(ProductInCart var)
        {
            return DataBaseEF.updatingDB.updateProductInCart(var);
        }

        public QRcode updateQRcode(QRcode var)
        {
            return DataBaseEF.updatingDB.updateQRcode(var);
        }

        public Store updateStore(Store var)
        {
            return DataBaseEF.updatingDB.updateStore(var);
        }
    }
}
