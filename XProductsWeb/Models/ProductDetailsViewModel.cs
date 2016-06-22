using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XProductsWeb.Models
{
    public class ProductDetailsViewModel
    {
        public Product Product { get; set; }

        public Category Category { get; set; }
    }
}
