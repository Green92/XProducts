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
    class LogProductFluent : EntityTypeConfiguration<LogProduct>
    {
        public LogProductFluent()
        {
            ToTable("APP_LOGPRODUCT");

            HasKey(lp => lp.Id);

            Property(lp => lp.Id).IsRequired().HasColumnName("LOG_ID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(lp => lp.Message).HasColumnName("LOG_MESSAGE").HasMaxLength(300);

            Property(lp => lp.Date).HasColumnName("LOG_DATE").IsRequired();

            Property(lp => lp.ProductId).HasColumnName("LOG_PRODUCTID");

            HasRequired(lp => lp.Product).WithMany(p => p.LogProducts).HasForeignKey(lp => lp.ProductId);
        }
    }
}
