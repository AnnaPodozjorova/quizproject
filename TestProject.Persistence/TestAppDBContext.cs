using Microsoft.EntityFrameworkCore;
using TestApp.Domain.Entities;
using TestApp.Persistence.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Persistence
{
    public class TestAppDbContext : DbContext
    {

        public DbSet<Answer> Answers { get; set; }
        public DbSet<AsnwerQuestionQuizUser> AsnwerQuestionQuizUsers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionQuiz> Journalists { get; set; }
        public DbSet<Quiz> Quizs { get; set; }
        public DbSet<QuizUser> QuizUsers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleUser> RoleUsers { get; set; }
        public DbSet<User> Users { get; set; }
        
        public TestAppDbContext(DbContextOptions<TestAppDbContext> options)
            : base(options)
        { }

        public TestAppDbContext(string connectionName)
        {
        }

        public TestAppDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Server=(localdb)\mssqllocaldb;Database=TestAppDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //one to many
            modelBuilder.Entity<Answer>()
                .HasMany(c => c.AsnwerQuestionQuizUsers).WithOne(c => c.Answer);
            modelBuilder.Entity<Question>()
                .HasMany(c => c.AsnwerQuestionQuizUsers).WithOne(c => c.Question);
            modelBuilder.Entity<Question>()
                .HasMany(c => c.Answers).WithOne(c => c.Question);
            modelBuilder.Entity<Quiz>()
                .HasMany(c => c.QuizUser).WithOne(c => c.Quiz);
            modelBuilder.Entity<User>()
                .HasMany(c => c.QuizUser).WithOne(c => c.User);
            modelBuilder.Entity<QuizUser>()
                .HasMany(c => c.AsnwerQuestionQuizUser).WithOne(c => c.QuizUser);

            modelBuilder.Entity<Answer>()
                .HasOne(c => c.Question).WithMany(c => c.Answers);
            modelBuilder.Entity<AsnwerQuestionQuizUser>()
                .HasOne(c => c.Answer).WithMany(c => c.AsnwerQuestionQuizUsers);
            modelBuilder.Entity<AsnwerQuestionQuizUser>()
                .HasOne(c => c.QuizUser).WithMany(c => c.AsnwerQuestionQuizUser);
            modelBuilder.Entity<AsnwerQuestionQuizUser>()
                .HasOne(c => c.Question).WithMany(c => c.AsnwerQuestionQuizUsers);
            modelBuilder.Entity<QuizUser>()
                .HasOne(c => c.User).WithMany(c => c.QuizUser);
            modelBuilder.Entity<QuizUser>()
                .HasOne(c => c.Quiz).WithMany(c => c.QuizUser);

            // many to many
            modelBuilder.Entity<RoleUser>().HasKey(ab => new { ab.RoleId, ab.UserId });
            modelBuilder.Entity<RoleUser>().HasOne(b => b.Role).WithMany(b => b.RoleUser).HasForeignKey(b => b.RoleId);
            modelBuilder.Entity<RoleUser>().HasOne(a => a.User).WithMany(a => a.RoleUser).HasForeignKey(a => a.UserId);

            modelBuilder.Entity<QuestionQuiz>().HasKey(ab => new { ab.QuizId, ab.QuestionsId });
            modelBuilder.Entity<QuestionQuiz>().HasOne(b => b.Quiz).WithMany(b => b.QuestionQuiz).HasForeignKey(b => b.QuizId);
            modelBuilder.Entity<QuestionQuiz>().HasOne(a => a.Question).WithMany(a => a.QuestionQuiz).HasForeignKey(a => a.QuestionsId);

            modelBuilder.ApplyConfiguration(new AnswerConfiguration());
            modelBuilder.ApplyConfiguration(new AnswerQuestionQuizUserConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionQuizConfiguration());
            modelBuilder.ApplyConfiguration(new QuizConfiguration());
            modelBuilder.ApplyConfiguration(new QuizUserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new RoleUserConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            //modelBuilder.seedData();
        }
    }
}
