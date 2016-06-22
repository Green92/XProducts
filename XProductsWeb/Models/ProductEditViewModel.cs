using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Model.Entities;
using System.Web.Mvc;

namespace XProductsWeb.Models
{
    public class ProductEditViewModel
    {
        public Product Product
        {
            get; set;
        }

        public List<Category> Categories { private get; set; }

        public IEnumerable<SelectListItem> CategoryItems
        {
            get
            {
                return new SelectList(Categories, "Id", "Wording");
            }
        }
    }
}