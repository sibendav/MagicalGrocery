using Accord.MachineLearning.Rules;
using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalGrocery.Model
{
    public class FamilyRecommendationModel
    {
        public Family thisFamily { get; set; }
        public List<Product> familyProducts { get; set; }

        public FamilyRecommendationModel(Family fam)
        {
            thisFamily = fam;
            familyProducts = forYouProduct(fam);
        }
        public List<Product> forYouProduct(Family fam)
        {
            List<AssociationRule<int>> associationRules;
            AprioriAlgorithm apriori = new AprioriAlgorithm();
            AssociationRule<int>[] result = apriori.AprioriAlgo();
            List<AssociationRule<int>> list = new List<AssociationRule<int>>();
            foreach (var item in result)
            {
                if (item.Confidence >= 0.5)
                    list.Add(item);
            }
            associationRules = list;

            List<Product> Allproducts = AddProductByAssociationRules(associationRules, fam);
            return Allproducts;
        }
        public List<Product> AddProductByAssociationRules(List<AssociationRule<int>> assos, Family fam)
        {
            List<Product> products = pupularProductCostumer(fam);
            foreach (var item in assos)
            {
                if (item.X.All(i => products.Contains(BLL.BLFactory.getBL().returnProduct(i))) == true)
                {
                    foreach (var i in item.Y)
                    {
                        products.Add(BLL.BLFactory.getBL().returnProduct(i));
                    }
                }
            }
            return products;
        }
        public List<Product> pupularProductCostumer(Family fam)
        {
            IBll bl = BLFactory.getBL();
            List<Product> Result = new List<Product>();
            List<ProductInCart> purchases = (from i in bl.returnAllProductInCart()
                                             where bl.returnCart(i.cartId).familyId == fam.familyId
                                             select i).ToList<ProductInCart>();
            var products = purchases
                .GroupBy(x => x.productId, (pid, purc) => new { productID = pid, Sum = purc.Sum(i => i.amount) });

            foreach (var item in products)
            {
                if (item.Sum > 1)
                    Result.Add(bl.returnProduct(item.productID));
            }
            return Result;
        }
    }
}
