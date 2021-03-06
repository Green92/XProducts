﻿using Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Initialisation
{
    public class ContextInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            IList<Product> defaultProducts = new List<Product>();

            Category boucherie = new Category() { Wording = "Charcuterie" };
            Category laitiers = new Category() { Wording = "Produits laitiers" };
            Category liquides = new Category() { Wording = "Liquides" };

            context.Categories.Add(boucherie);
            context.Categories.Add(laitiers);
            context.Categories.Add(liquides);

            defaultProducts.Add(new Product() {
                Name = "Steak",
                Category = boucherie,
                CategoryId = boucherie.Id,
                Active = true,
                Description = "cgcggcgcgc gcgc gc fgvcgc gc ",
                Stock = 10,
                Price = 20
            });

            defaultProducts.Add(new Product() {
                Name = "Jambon",
                Category = boucherie,
                CategoryId = boucherie.Id,
                Active = true,
                Description = "",
                Stock = 10,
                Price = 20
            });

            defaultProducts.Add(new Product() {
                Name = "Yaourts",
                Category = laitiers,
                CategoryId = laitiers.Id,
                Active = true,
                Description = "",
                Stock = 10,
                Price = 20
            });

            defaultProducts.Add(new Product() {
                Name = "Glace",
                Category = laitiers,
                CategoryId = laitiers.Id,
                Active = true,
                Description = "",
                Stock = 10,
                Price = 20
            });

            defaultProducts.Add(new Product() {
                Name = "Coca Cola",
                Category = liquides,
                CategoryId = liquides.Id,
                Active = true,
                Description = "",
                Stock = 10,
                Price = 20
            });

            defaultProducts.Add(new Product() {
                Name = "Captain Morgan",
                Category = liquides,
                CategoryId = liquides.Id,
                Active = true,
                Description = "",
                Stock = 10,
                Price = 20
            });

            foreach (Product p in defaultProducts)
            {
                context.Products.Add(p);
            }

            base.Seed(context);
        }
    }
}
