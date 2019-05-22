using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Persistence.Configurations
{
    public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder.HasKey(e => e.QuizId);
            builder.Property(u => u.QuizId).ValueGeneratedOnAdd();
        }
    }
}
