using System.Collections.Generic;

namespace Model.Entities
{
    public class Client
    {
        public int Id { get; set; }

        public string Nom { get; set;  }

        public string Prenom { get; set; }

        public bool Actif { get; set;  }

        public ICollection<Command> Commands { get; set; }
    }
}