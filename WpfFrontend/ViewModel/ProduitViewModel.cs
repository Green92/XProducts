using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.Entities;

namespace WpfFrontend.ViewModel
{
    public class ProduitViewModel : BaseViewModel
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Libelle { get; set; }

        public string Description { get; set; }

        public bool Actif { get; set; }

        public int Stock { get; set; }

        public int Prix { get; set; }

        public Category Category { get; set; }

        public ProduitViewModel(Product produit)
        {
            Id = produit.Id;
            Category = produit.Category;
        }
    }
}
