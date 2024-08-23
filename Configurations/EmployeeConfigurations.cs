using EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Configurations
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(E => E.EmpId);

            builder.Property(E => E.EmpId)
                    .UseIdentityColumn(1, 1);


            builder.Property(E => E.EmpId)
                        .HasColumnType("varchar")
                        .HasMaxLength(50);


            builder.Property(E => E.Salary)
                   .HasColumnType("money");


         
        }
    }
}
