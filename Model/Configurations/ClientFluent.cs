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
    public class ClientFluent : EntityTypeConfiguration<Client>
    {
        public ClientFluent ()
        {
            ToTable("APP_CLIENT");

            HasKey(c => c.Id);
            Property(c => c.Id).HasColumnName("CLI_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Nom).IsRequired().HasColumnName("CLI_NOM").HasMaxLength(100);

            Property(c => c.Prenom).HasColumnName("CLI_PRENOM").HasMaxLength(100);

            Property(c => c.Actif).HasColumnName("CLI_ACTIF").IsRequired();
        }
    }
}
