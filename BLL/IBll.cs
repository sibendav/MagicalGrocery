using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IBll
    {
        bool addFamily(Family var);
        bool updateFamily(Family var);
        bool deleteFamily(Family var);

        bool addAddress(Address var);
        bool updateAddress(Address var);
        bool deleteAddress(Address var);

        bool addStore(Store var);
        bool updateStore(Store var);
        bool deleteStore(Store var);

        bool addProduct(Product var);
        bool updateProduct(Product var);
        bool deleteProduct(Product var);

        bool addCart(Cart var);
        bool updateCart(Cart var);
        bool deleteCart(Cart var);

        bool addProductInCart(ProductInCart var);
        bool updateProductInCart(ProductInCart var);
        bool deleteProductInCart(ProductInCart var);

        bool addQRcode(QRcode var);
        bool updateQRcode(QRcode var);
        bool deleteQRcode(QRcode var);

        Family returnFamily(int var);
        Address returnAddress(int var);
        Store returnStore(int var);
        Product returnProduct(int var);
        Cart returnCart(int var);
        ProductInCart returnProductInCart(int var);
        QRcode returnQRcode(int var);

        List<Family> returnAllFamily();
        List<Address> returnAllAddress();
        List<Store> returnAllStore();
        List<Product> returnAllProduct();
        List<Cart> returnAllCart();
        List<ProductInCart> returnAllProductInCart();
        List<QRcode> returnAllQRcode();

        List<Cart> returnAllOfFamilyCart(int var);
        List<Cart> returnAllProductsInCart(int var);
    }
}
