using Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
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
            Property(p => p.Description).HasColumnName("PRD_DESCRIPTION").HasMaxLength(2048);
            Property(p => p.Active).HasColumnName("PRD_ACTIVE");
            Property(p => p.Stock).HasColumnName("PRD_STOCK").IsRequired();
            Property(p => p.Price).HasColumnName("PRD_PRICE").IsRequired();
            Property(p => p.Code).HasColumnName("PRD_CODE").IsRequired().HasMaxLength(10)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute()));

            HasRequired(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId);
        }
    }
}
