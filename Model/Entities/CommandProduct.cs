using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class CommandProduct
    {
        public int Quantity { get; set; }

        public int CommandId { get; set; }
        public Command Command { get; set; }

        public int ProductId { get; set;  }
        public Product Product { get; set; }

        public CommandProduct()
        {
            Quantity = 1;
        }
    }
}
