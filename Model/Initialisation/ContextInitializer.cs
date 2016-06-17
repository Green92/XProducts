using Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Initialisation
{
    public class ContextInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            IList<Category> defaultCategories = new List<Category>();

            defaultCategories.Add(new Category() { Wording = "Charcuterie" });
            defaultCategories.Add(new Category() { Wording = "Produits laitiers" });
            defaultCategories.Add(new Category() { Wording = "Liquides" });

            foreach (Category category in defaultCategories)
                context.Categories.Add(category);

            base.Seed(context);
        }
    }
}
