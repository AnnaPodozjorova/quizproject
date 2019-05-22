using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Persistence.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(e => e.RoleID);
            builder.Property(u => u.RoleID).ValueGeneratedOnAdd();
        }
    }
}
