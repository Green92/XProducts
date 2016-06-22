using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Entities;

namespace BusinessLayer.Queries
{
    public class ProductQuery
    {
        private readonly Context _context;

        public ProductQuery(Context context)
        {
            _context = context;
        }

        public IQueryable<Product> GetAll()
        {
            return _context.Products;
        }

        public IQueryable<Product> GetById(int id)
        {
            return _context.Products.Where(p => p.Id == id);
        }

        public IQueryable<Product> GetByCategoryId(int id)
        {
            return _context.Products.Where(p => p.CategoryId == id);
        }

        public IQueryable<Product> GetByCategoryIdAndName(int id, String name)
        {
            return _context.Products.Where(p => p.CategoryId == id && p.Name.Contains(name));
        }

        public IQueryable<Product> GetByName(String name)
        {
            return _context.Products.Where(p => p.Name.Contains(name));
        }
    }
}