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
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("employess");
            builder.HasKey(e => e.EmpId);

            builder.Property(em=>em.Name)
                .IsRequired()
                .HasColumnName("EmployeeName").HasMaxLength(20);

            builder.Property(e=>e.Address).HasMaxLength(50) .IsRequired();

            builder.Property(e=>e.Gender).HasMaxLength(6) .IsRequired();

            // add employeeQualifications

            builder.HasMany(em => em.EmpQualifications)
                .WithOne()
                .HasForeignKey(q => q.EmployeeId);
                 
            
        }
    }
}
