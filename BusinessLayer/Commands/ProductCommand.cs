using Model;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Commands
{
    public class ProductCommand
    {
        private readonly Context _context;

        public ProductCommand(Context context)
        {
            _context = context;
        }

        public int Add(Product p)
        {
            _context.Products.Add(p);
            return _context.SaveChanges();
        }

        public void Edit(Product p)
        {
            Product upPrd = _context.Products.Where(prd => prd.Id == p.Id).FirstOrDefault();
            if (upPrd != null)
            {
                upPrd.Name = p.Name;
                upPrd.CategoryId = p.CategoryId;
            }
            _context.SaveChanges();
        }

        public void Delete(int productId)
        {
            Product delPrd = _context.Products.Where(prd => prd.Id == productId).FirstOrDefault();
            if (delPrd != null)
            {
                _context.Products.Remove(delPrd);
            }
            _context.SaveChanges();
        }
    }
}
