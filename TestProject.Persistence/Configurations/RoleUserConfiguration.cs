using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Persistence.Configurations
{
    public class RoleUserConfiguration : IEntityTypeConfiguration<RoleUser>
    {
        public void Configure(EntityTypeBuilder<RoleUser> builder)
        {
            builder.HasKey(e => e.RoleUserId);
            builder.Property(u => u.RoleUserId).ValueGeneratedOnAdd();
        }
    }
}
