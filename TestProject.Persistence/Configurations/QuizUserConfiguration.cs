using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Persistence.Configurations
{
    public class QuizUserConfiguration : IEntityTypeConfiguration<QuizUser>
    {
        public void Configure(EntityTypeBuilder<QuizUser> builder)
        {
            builder.HasKey(e => e.QuizUserId);
            builder.Property(u => u.QuizUserId).ValueGeneratedOnAdd();
        }
    }
}
