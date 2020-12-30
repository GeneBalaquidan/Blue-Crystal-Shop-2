using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.Data.Entity;

namespace Blue_Crystal.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Men"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Women"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Boys"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Girls"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Accessories"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Denim Shirt 1",
                    Description = "A casual denim shirt",
                    ImagePath="images/Denim-shirts-m1.jpg",
                    UnitPrice = 24.95,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Denim Shirt 2",
                    Description = "A casual denim shirt.",
                    ImagePath="images/Denim-shirts-m2.jpg",
                    UnitPrice = 24.95,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Denim Shirt 3",
                    Description = "A casual denim shirt.",
                    ImagePath="images/Denim-shirts-m3.jpg",
                    UnitPrice = 24.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Denim Shirt 4",
                    Description = "A casual denim shirt.",
                    ImagePath="images/Denim-shirts-m4.jpg",
                    UnitPrice = 24.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Avon Daphne Uwire Bra",
                    Description = "A brassier made by Avon",
                    ImagePath="images/avon-daphne-uwire-bra.jpg",
                    UnitPrice = 34.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Avon Lipstick Shimmer",
                    Description = "A shimmering lipstick made by Avon.",
                    ImagePath="images/avon-lipstick-shimmer.jpg",
                    UnitPrice = 24.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Baby Boy Short 1",
                    Description = "A casual short for baby boy.",
                    ImagePath="images/Evelin-lee-baby-boy-short.jpg",
                    UnitPrice = 4.95,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Baby Boy Short 2",
                    Description = "A casual short for baby boy.",
                    ImagePath="images/Evelin-lee-baby-boy-short2.jpg",
                    UnitPrice = 2.95,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Baby Boy T-shirt + Short Set 1",
                    Description = "A set of T-shirt and Short for a baby boy.",
                    ImagePath="images/Evelin-lee-baby-boy-t-shirt-short-set.jpg",
                    UnitPrice = 15.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Baby Boy T-shirt + Short Set 2",
                    Description = "A set of T-shirt and Short for a baby boy.",
                    ImagePath="images/Evelin-lee-baby-boy-t-shirt-short-set2.jpg",
                    UnitPrice = 15.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Baby Boy T-shirt + Short Set 3",
                    Description = "A set of T-shirt and Short for a baby boy.",
                    ImagePath="images/Evelin-lee-baby-boy-t-shirt-short-set3.jpg",
                    UnitPrice = 15.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Baby Boy T-shirt + Short Set 4",
                    Description = "A set of T-shirt and Short for a baby boy.",
                    ImagePath="images/Evelin-lee-baby-boy-t-shirt-short-set4.jpg",
                    UnitPrice = 15.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Baby Boy T-shirt + Short Set 5",
                    Description = "A set of T-shirt and Short for a baby boy",
                    ImagePath="images/Evelin-lee-baby-boy-t-shirt-short-set5.jpg",
                    UnitPrice = 15.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Flower Girl's Evening Gown",
                    Description = "An enchanting evening gown for a flower girl.",
                    ImagePath="images/pretty-lace-hi-low-lace-flower-girl-evening-gown.jpg",
                    UnitPrice = 50.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Baptism Dress",
                    Description = "A beautiful dress perfect for baptism of a young girl.",
                    ImagePath="images/Toddler-Girl-Baptism-Dress.jpg",
                    UnitPrice = 40.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Baby Girl Frock Dress",
                    Description = "A pretty frock dress for a young girl.",
                    ImagePath="images/pretty-baby-girl-frock.jpg",
                    UnitPrice = 30.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 17,
                    ProductName = "LV Vivienne Necklace",
                    Description = "A beautiful necklace by Louis Vuitton.",
                    ImagePath="images/lv-vivienne-necklace.jpg",
                    UnitPrice = 122.95,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 17,
                    ProductName = "LV Colar",
                    Description = "A colar made by Louis Vuitton.",
                    ImagePath="images/lv-colar.jpg",
                    UnitPrice = 74.95,
                    CategoryID = 5
                }
            };

            return products;
        }
    }
}