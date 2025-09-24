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
    internal class AireCraftConfiguration : IEntityTypeConfiguration<AireCraft>
    {
        public void Configure(EntityTypeBuilder<AireCraft> builder)
        {
            builder.OwnsOne(a => a.crewDetails)
                .WithOwner();


            builder.HasOne(e => e.AireLineOwner)
                .WithMany(A => A.airecraftsOwned)
                .HasForeignKey(e => e.AireLineOwnerId)
                .IsRequired(false);
              
           
                
            
        }
    }
}
