using Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Configurations
{
    class ProductFluent : EntityTypeConfiguration<Product>
    {
        public ProductFluent()
        {
            ToTable("APP_PRODUCT");
            HasKey(p => p.Id);

            Property(p => p.Id).HasColumnName("PRD_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Name).HasColumnName("PRD_NAME").IsRequired().HasMaxLength(100);

            HasRequired(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId);
        }
    }
}
