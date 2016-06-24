using Model.Entities;
using Model.Initialisation;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Context : DbContext
    {
        public Context()
            : base("name=ConnectionStr")
        {
            Database.SetInitializer<Context>(new ContextInitializer());
            //Database.SetInitializer<Context>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Command> Commands { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<LogProduct> LogProducts { get; set; }

        public DbSet<Status> Status { get; set; }

        public DbSet<CommandProduct> CommandProducts { get; set; }
    }
}
