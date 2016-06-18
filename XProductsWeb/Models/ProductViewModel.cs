using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Model.Entities;
using System.Web.Mvc;

namespace XProductsWeb.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }

        public List<Category> Categories { get; set; }

        public int SelectedCategory { get; set; }

        public String Search { get; set; }

        public IEnumerable<SelectListItem> CategoryItems
        {
            get {
                List<Category> categories = new List<Category>();
                categories.Add(new Category()
                {
                    Id = 0,
                    Wording = "All"
                });

                if (Categories.Count > 0)
                {
                    categories.AddRange(Categories);
                }

                return new SelectList(categories, "Id", "Wording");
            }
        }

        //public int SelectedCategoryId
        //{
        //    get {
        //        int result = 0;
        //        if (SelectedCategory != null)
        //        {
        //            int.TryParse(SelectedCategory.Value, out result);
        //        }

        //        return result;
        //    }
        //}
    }
}