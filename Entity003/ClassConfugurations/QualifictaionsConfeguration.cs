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
    internal class QualifictaionsConfeguration : IEntityTypeConfiguration<Qualifacion>
    {
        public void Configure(EntityTypeBuilder<Qualifacion> builder)
        {
            builder.ToTable("employeeQualifications");
            builder.HasKey(q => new{ q.EmployeeId ,q.Qualificatons});
            builder.Property(q=>q.Qualificatons).HasMaxLength(50).IsRequired();
       
        }
    }
}
