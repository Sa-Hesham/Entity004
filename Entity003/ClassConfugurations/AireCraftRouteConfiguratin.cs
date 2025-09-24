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
    internal class AireCraftRouteConfiguratin : IEntityTypeConfiguration<AireCraftRoute>
    {
        public void Configure(EntityTypeBuilder<AireCraftRoute> builder)
        {

            builder.HasOne(Ai => Ai.AireCraft)
                .WithMany(r => r.AireCraftAssign)
                .HasForeignKey(fk => fk.AireCraftId);



            builder.HasOne(Ai=>Ai.Routes)
                .WithMany(r=>r.routes)
                .HasForeignKey(Fk=>Fk.RouteId);



            builder.HasKey(key => new { key.AireCraftId, key.RouteId });
        }
    }
}
