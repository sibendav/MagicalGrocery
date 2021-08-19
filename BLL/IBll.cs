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
        Family addFamily(Family var);
        Family updateFamily(Family var);
        bool deleteFamily(Family var);

        Address addAddress(Address var);
        Address updateAddress(Address var);
        bool deleteAddress(Address var);

        Store addStore(Store var);
        Store updateStore(Store var);
        bool deleteStore(Store var);

        Product addProduct(Product var);
        Product updateProduct(Product var);
        bool deleteProduct(Product var);

        Cart addCart(Cart var);
        Cart updateCart(Cart var);
        bool deleteCart(Cart var);

        ProductInCart addProductInCart(ProductInCart var);
        ProductInCart updateProductInCart(ProductInCart var);
        bool deleteProductInCart(ProductInCart var);

        QRcode addQRcode(QRcode var);
        QRcode updateQRcode(QRcode var);
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
