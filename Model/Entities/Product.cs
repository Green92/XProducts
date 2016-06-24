using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool Active { get; set; }

        public int Stock { get; set; }

        public double Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<CommandProduct> CommandProducts { get; set; }
    }
}
