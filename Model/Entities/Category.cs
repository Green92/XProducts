﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Wording { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        public override string ToString()
        {
            return Wording;
        }
    }
}
