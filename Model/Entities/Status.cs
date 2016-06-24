using System.Collections.Generic;

namespace Model.Entities
{
    public class Status
    {

        public int Id { get; set; }

        public ICollection<Command> Commands { get; set; }

        public string Libelle { get; set; }

    }
}