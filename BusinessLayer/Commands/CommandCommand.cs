using Model;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Commands
{
    class CommandCommand
    {
        private readonly Context _context;

        public CommandCommand(Context context)
        {
            _context = context;
        }

        public int Add(Command c)
        {
            _context.Commands.Add(c);
            return _context.SaveChanges();
        }

        public void Edit(Command c)
        {
            Command upCmd = _context.Commands.Where(co => co.Id == c.Id).FirstOrDefault();
            if (upCmd != null)
            {
                upCmd.Status = c.Status;
                upCmd.Observation = c.Observation;
                upCmd.DateCommande = c.DateCommande;
                upCmd.CommandProducts = c.CommandProducts;
                upCmd.Client = c.Client;
            }
            _context.SaveChanges();
        }

        public void Delete(int commandId)
        {
            Command delCmd = _context.Commands.Where(cmd => cmd.Id == commandId).FirstOrDefault();
            if (delCmd != null)
            {
                _context.Commands.Remove(delCmd);
            }
            _context.SaveChanges();
        }
    }
}
