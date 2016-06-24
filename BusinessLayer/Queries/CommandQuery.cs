using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.Entities;
using Model;

namespace BusinessLayer.Queries
{
    public class CommandQuery
    {
        private readonly Context _context;

        public CommandQuery(Context context)
        {
            _context = context;
        }

        public IQueryable<Command> GetAll()
        {
            return _context.Commands;
        }

        public IQueryable<Command> GetById(int id)
        {
            return _context.Commands.Where(c => c.Id == id);
        }
    }
}
