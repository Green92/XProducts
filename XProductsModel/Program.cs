using BusinessLayer;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XProductsModel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                BusinessManager bm = BusinessManager.Instance;

                List<Category> categories = bm.GetAllCategories();
                System.Console.WriteLine("---- liste des categories -----");
                foreach (Category c in categories)
                {
                    System.Console.WriteLine("catégorie id {0} : {1}", c.Id, c.Wording);
                }

                Product product = new Product();
                product.Name = "Test";
                product.Category = categories.FirstOrDefault();
                product.Code = "gqsjhdgqs";

                bm.AddProduct(product);

                List<Product> products = bm.GetAllProducts();
                System.Console.WriteLine("---- LISTE DES PRODUITS -----");
                foreach (Product p in products)
                {
                    System.Console.WriteLine("Catégorie {0} : {1}", p.Category, p.Name);
                }
            } catch (Exception e)
            {
                Console.WriteLine(String.Format("Erreur : {0}", e.Message));
            }
        }
    }
}
