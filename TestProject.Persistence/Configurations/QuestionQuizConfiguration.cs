using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestApp.Domain.Entities;

namespace TestApp.Persistence.Configurations
{
    class QuestionQuizConfiguration : IEntityTypeConfiguration<QuestionQuiz>
    {
        public void Configure(EntityTypeBuilder<QuestionQuiz> builder)
        {
            builder.HasKey(e => e.QuestionQuizId);
            builder.Property(u => u.QuestionQuizId).ValueGeneratedOnAdd();
        }
    }
}
