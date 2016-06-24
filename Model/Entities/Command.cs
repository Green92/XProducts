using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Command
    {
        public int Id { get; set;  }

        public DateTime DateCommande { get; set;  }

        public string Observation { get; set;  }

        public int StatusId { get; set;  }
        public Status Status { get; set; }

        public int ClientId { get; set;  }
        public Client Client { get; set;  }
    }
}
