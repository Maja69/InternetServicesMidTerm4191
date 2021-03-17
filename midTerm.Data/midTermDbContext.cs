using Microsoft.EntityFrameworkCore;
using midTerm.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using DbContext = System.Data.Entity.DbContext;

namespace midTerm.Data
{
     public class midTermDbContext : DbContext
    {
        public System.Data.Entity.DbSet<Answers> Answers { get; set; }
        public System.Data.Entity.DbSet<Option> Options { get; set; }
        public System.Data.Entity.DbSet<Question> Questions { get; set; }
        public System.Data.Entity.DbSet<SurveyUser> SurveyUsers { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answers>(Answers =>
                {
                    Answers.Property(p => p.Id).IsRequired();
                    Answers.Property(p => p.UserId).IsRequired();
                    Answers.Property(p => p.OptionId).IsRequired();
                    Answers.HasKey(p => p.Id);
                    Answers.Property(p => p.UserId).HasMaxLength(600).IsRequired();
                    Answers.HasMany(p => p.Questions);
                    Answers.ToTable("Answers");

                });
            modelBuilder.Entity<Option>(Option =>
            {
                Option.Property(p => p.Id).IsRequired();
                Option.Property(p => p.Text).IsRequired();
                Option.Property(p => p.Order).IsRequired();
                Option.Property(p => p.QuestionId).IsRequired();
                Option.HasKey(p => p.Id);
                Option.Property(p => p.UserId).HasMaxLength(600).IsRequired();
                Option.HasMany(p => p.Questions);
                Option.ToTable("Options");
            });
            modelBuilder.Entity<Question>(Question =>
            {
                Question.Property(p => p.Id).IsRequired();
                Question.Property(p => p.Text).IsRequired();
                Question.Property(p => p.Description).IsRequired();
                Question.HasKey(p => p.Id);
                Question.Property(p => p.UserId).HasMaxLength(600).IsRequired();
                Question.HasMany(p => p.Questions);
                Question.ToTable("Questions");
            });
            modelBuilder.Entity<SurveyUser>(SurveyUser =>
            {
                SurveyUser.Property(p => p.Id).IsRequired();
                SurveyUser.Property(p => p.FirstName).IsRequired();
                SurveyUser.Property(p => p.LastName).IsRequired();
                SurveyUser.Property(p => p.DoB).IsRequired();
                SurveyUser.Property(p => p.Gender).IsRequired();
                SurveyUser.Property(p => p.Country).IsRequired();
                SurveyUser.HasKey(p => p.Id);
                SurveyUser.Property(p => p.UserId).HasMaxLength(600).IsRequired();
                SurveyUser.Property(p => p.FirstName).HasMaxLength(100).IsRequired();
                SurveyUser.HasMany(p => p.Questions);
                SurveyUser.ToTable("Questions");
            });
        }
    }
}
