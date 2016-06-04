using Model;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    public class CategoryQuery
    {
        private readonly Context _context;

        public CategoryQuery(Context context)
        {
            _context = context;
        }

        public IQueryable<Category> GetAll()
        {
            return _context.Categories;
        }

        public IQueryable<Category> GetById(int id)
        {
            return _context.Categories.Where(p => p.Id == id);
        }
    }
}
