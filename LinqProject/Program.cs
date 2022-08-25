using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{ CategoryId=1, CategoryName="Bilgisayar"},
                new Category{ CategoryId=2, CategoryName="Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ ProductId=1, CategoryId=1, ProductName="Acer Laptop", QuantityPerUnit="32 GB RAM", UnitPrice=10000, UnitsInStock=5 },
                new Product{ ProductId=2, CategoryId=1, ProductName="Asus Laptop", QuantityPerUnit="16 GB RAM", UnitPrice=18000, UnitsInStock=3 },
                new Product{ ProductId=3, CategoryId=1, ProductName="Hp Laptop", QuantityPerUnit="8 GB RAM", UnitPrice=18000, UnitsInStock=2 },
                new Product{ ProductId=4, CategoryId=2, ProductName="Samsung Telefon", QuantityPerUnit="4 GB RAM", UnitPrice=5000, UnitsInStock=15 },
                new Product{ ProductId=5, CategoryId=2, ProductName="Apple Telefon", QuantityPerUnit="4 GB RAM", UnitPrice=8000, UnitsInStock=0 }
            };
            // Test(products);
            // AnyTest(products);
            // FindTest(products);
            // FindAllTest(products);
            // AscDescTest(products);
            // ClassicLinqTest(products);
            // JoinTest(categories, products);

        }

        private static void JoinTest(List<Category> categories, List<Product> products)
        {
            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice > 5000
                         orderby p.UnitPrice descending
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, CategoryName = c.CategoryName, UnitPrice = p.UnitPrice };

            foreach (var productDto in result)
            {
                Console.WriteLine("{0} : {1}", productDto.ProductName, productDto.CategoryName);
            }
        }

        private static void ClassicLinqTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 6000
                         orderby p.UnitPrice, p.UnitsInStock descending
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void AscDescTest(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(P => P.UnitPrice).ThenByDescending(p => p.ProductName);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top"));  // FindAll() ve Where() birbirine benzemekte olsa bile
            Console.WriteLine(result);                                          // FindAll'da direk bir liste olarak çalışır ama Where öyle değildir.
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(P => P.ProductId == 7);   // Find() metotundaysa eğer değer varsa o değeri yoksa null değerini döndürür.
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Acer Laptop");   // Any metotu ile bir değerin var olup olmadığını kontrol eder ve ona göre
            Console.WriteLine(result);                                        //  true ya da false döner.
        }

        private static void Test(List<Product> products)
        {
            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
    class ProductDto
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }
    
    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
