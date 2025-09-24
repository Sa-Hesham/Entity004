using Entity003.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity003.ClassConfugurations
{
    public class phonesConfegurations : IEntityTypeConfiguration<Phones>
    {
        public void Configure(EntityTypeBuilder<Phones> builder)
        {
            builder.Property(p => p.Phonenumber)
                .IsRequired()
                .HasMaxLength(15);


           builder.HasKey(p => new {p.Phonenumber ,p.AireLine_Id});

        }
    }
}
