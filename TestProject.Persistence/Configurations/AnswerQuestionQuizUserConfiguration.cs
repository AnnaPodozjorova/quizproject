using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestApp.Domain.Entities;

namespace TestApp.Persistence.Configurations
{
    public class AnswerQuestionQuizUserConfiguration : IEntityTypeConfiguration<AsnwerQuestionQuizUser>
    {
        public void Configure(EntityTypeBuilder<AsnwerQuestionQuizUser> builder)
        {
            builder.HasKey(e => e.AsnwerQuestionQuizUserId);
            builder.Property(u => u.AsnwerQuestionQuizUserId).ValueGeneratedOnAdd();
        }
    }
}
