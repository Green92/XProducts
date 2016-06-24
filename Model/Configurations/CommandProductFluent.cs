using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Model.Entities;

namespace Model.Configurations
{
    public class CommandProductFluent : EntityTypeConfiguration<CommandProduct>
    {
        public CommandProductFluent()
        {
            ToTable("APP_COMMANDPRODUCT");

            HasKey(cp => new { cp.CommandId, cp.ProductId });

            Property(cp => cp.CommandId).HasColumnName("CPD_COMMANDID");

            Property(cp => cp.ProductId).HasColumnName("CPD_PRODUCTID");

            Property(cp => cp.Quantity).HasColumnName("CPD_QUANTITY").IsRequired();

            HasRequired(cp => cp.Product).WithMany(p => p.CommandProducts).HasForeignKey(cp => cp.ProductId);

            HasRequired(cp => cp.Command).WithMany(c => c.CommandProducts).HasForeignKey(cp => cp.CommandId);
        }
    }
}
