using Entity003.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Transaction = Entity003.Models.Transaction;

namespace Entity003.ClassConfugurations
{
    internal class TransacionConfegurations : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("aireLineTransaction");
            builder.HasKey(t => t.TransactId);


            builder.Property(bi => bi.discription)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            builder.Property(bi => bi.Amuont)
                .IsRequired();

            builder.Property(bi => bi.Date)
              .HasDefaultValueSql("GETDATE()");
        }
    }
}
