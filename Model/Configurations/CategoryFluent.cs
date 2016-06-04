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
    class CategoryFluent : EntityTypeConfiguration<Category>
    {

        public CategoryFluent()
        {
            ToTable("APP_CATEGORY");
            HasKey(c => c.Id);

            Property(c => c.Id).HasColumnName("CAT_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Wording).HasColumnName("CAT_NAME").IsRequired().HasMaxLength(100);
        }
    }
}
