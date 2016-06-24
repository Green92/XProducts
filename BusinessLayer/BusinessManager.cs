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
        private readonly Context context;
        private static BusinessManager _businessManager = null;

        private BusinessManager()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);
            context = new Context();
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

        public Command GetCommand(int id)
        {
            throw new NotImplementedException();
        }

        public List<Command> GetAllCommands()
        {
            throw new NotImplementedException();
        }

        #region Product

        public List<Product> GetAllProducts()
        {
            ProductQuery pq = new ProductQuery(context);
            return pq.GetAll().ToList();
        }

        public Product GetProductById(int id)
        {
            ProductQuery pc = new ProductQuery(context);
            
            return pc.GetById(id).FirstOrDefault();
        }

        public List<Product> GetProductsByCategoryId(int id)
        {
            ProductQuery pc = new ProductQuery(context);

            return pc.GetByCategoryId(id).ToList();
        }

        public List<Product> GetProductsByCategoryIdAndName(int id, String name)
        {
            ProductQuery pc = new ProductQuery(context);

            return pc.GetByCategoryIdAndName(id, name).ToList();
        }

        public List<Product> GetProductsByName(String name)
        {
            ProductQuery pc = new ProductQuery(context);

            return pc.GetByName(name).ToList();
        }

        public int AddProduct(Product p)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            ProductCommand pc = new ProductCommand(context);
            return pc.Add(p);
        }

        public void EditProduct(Product p)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            ProductCommand pc = new ProductCommand(context);
            pc.Edit(p);
        }

        public void DeleteProduct(int productId)
        {
            ProductCommand pc = new ProductCommand(context);
            pc.Delete(productId);
        }

        #endregion

        #region Category

        public List<Category> GetAllCategories()
        {
            CategoryQuery pq = new CategoryQuery(context);
            return pq.GetAll().ToList();
        }

        public Category GetCategoryById(int id)
        {
            CategoryQuery pc = new CategoryQuery(context);

            return pc.GetById(id).FirstOrDefault();
        }

        #endregion
    }
}
