using Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Configurations
{
    class CommandFluent : EntityTypeConfiguration<Command>
    {

        public CommandFluent ()
        {
            ToTable("APP_COMMAND");

            HasKey(c => c.Id);
     
            Property(c => c.Id).HasColumnName("CMD_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.DateCommande).HasColumnName("CMD_NOM").IsRequired();

            Property(c => c.Observation).HasColumnName("CMD_OBSERVATION").HasMaxLength(100);

            Property(c => c.StatusId).HasColumnName("CMD_STATUSID");

            Property(c => c.ClientId).HasColumnName("CMD_CLIENTID");

            HasRequired(c => c.Status).WithMany(s => s.Commands).HasForeignKey(c => c.StatusId);

            HasRequired(c => c.Client).WithMany(cli => cli.Commands).HasForeignKey(c => c.ClientId);
        }

    }
}
