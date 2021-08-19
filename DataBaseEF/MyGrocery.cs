using BE;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;

namespace DataBaseEF
{
    public class MyGrocery : DbContext
    {
        public MyGrocery() : base("MyGrocery")
        {
            Database.SetInitializer<MyGrocery>(new CreateDatabaseIfNotExists<MyGrocery>());
        }

        public DbSet<Family> Families { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInCart> ProductInCarts { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<QRcode> QRcodes { get; set; }


    }

}
