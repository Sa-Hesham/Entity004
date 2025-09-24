using Entity003.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity003.ClassConfugurations
{
    internal class AireLineConfigurations : IEntityTypeConfiguration<AireLine>
    {
        public void Configure(EntityTypeBuilder<AireLine> builder)
        {
            builder.HasKey(A=>A.AireLineId);

            builder.Property(props => props.AireLineId)
                .UseIdentityColumn(1, 1);

            builder.Property(builder => builder.AireLine_Name)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(prop=>prop.Adress).HasColumnName("AireLineAdress")
                .HasMaxLength(60);

            builder.Property(b => b.ContactPerson).IsRequired(false);


            // Add Phone table to aireline 

          builder.HasMany(Air=>Air.AirelinePhones)
                .WithOne()
                .HasForeignKey(p=>p.AireLine_Id)
                .OnDelete(DeleteBehavior.Restrict);


            //add relationship With Employee 

            builder.HasMany(builder => builder.employeesworks)
                .WithOne(e => e.AireLine)
                .HasForeignKey(e=>e.AireId)
                .OnDelete(DeleteBehavior.Restrict);



            builder.HasMany(a => a.transactions)
                .WithOne(t => t.aireLine)
                .HasForeignKey(t => t.AireLineId);

          
        }
    }
}
