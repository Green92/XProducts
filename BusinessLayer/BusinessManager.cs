using BusinessLayer.Commands;
using BusinessLayer.Queries;
using Model;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessManager
    {
        private readonly Context contexte;
        private static BusinessManager _businessManager = null;

        private BusinessManager()
        {
            contexte = new Context();
        }

        /// <summary>
        /// Récupérer l'instance du pattern Singleton
        /// </summary>
        public static BusinessManager Instance
        {
            get
            {
                if (_businessManager == null)
                    _businessManager = new BusinessManager();
                return _businessManager;
            }
        }

        #region Product

        public List<Product> GetAllProduit()
        {
            ProductQuery pq = new ProductQuery(contexte);
            return pq.GetAll().ToList();
        }

        public int AjouterProduit(Product p)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            ProductCommand pc = new ProductCommand(contexte);
            return pc.Add(p);
        }

        public void ModifierProduit(Product p)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            ProductCommand pc = new ProductCommand(contexte);
            pc.Edit(p);
        }

        public void SupprimerProduit(int produitID)
        {
            ProductCommand pc = new ProductCommand(contexte);
            pc.Delete(produitID);
        }

        #endregion

        #region Category

        /// <summary>
        /// Récupérer une liste de catégories en base
        /// </summary>
        /// <returns>Liste de Categorie</returns>
        public List<Category> GetAllCategorie()
        {
            CategoryQuery pq = new CategoryQuery(contexte);
            return pq.GetAll().ToList();
        }

        #endregion
    }
}
