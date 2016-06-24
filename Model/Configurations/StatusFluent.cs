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
    class StatusFluent : EntityTypeConfiguration<Status>
    {
        public StatusFluent()
        {
            ToTable("APP_STATUS");

            HasKey(s => s.Id);
            Property(s => s.Id).HasColumnName("STA_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(s => s.Libelle).HasColumnName("STA_LIBELLE").IsRequired().HasMaxLength(100);
        }
    }
}
