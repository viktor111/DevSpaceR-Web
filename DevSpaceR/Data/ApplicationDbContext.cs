using DevSpaceR.Helpers;
using DevSpaceR.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevSpaceR.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>(entity => 
            {
                entity
                .Property("Name")
                .HasMaxLength(UserEntityConstants.NameMaxLength)
                .IsRequired(UserEntityConstants.NameRequired);

                entity
                .Property("PhoneNumber")
                .HasMaxLength(UserEntityConstants.PhoneNumberMaxLength)
                .IsRequired(UserEntityConstants.PhoneNumberRequired);

                entity
                .Property("Country")
                .HasMaxLength(UserEntityConstants.CountryMaxLength)
                .IsRequired(UserEntityConstants.CountryRequired);

                entity
                .Property("Description")
                .HasMaxLength(UserEntityConstants.DescriptionMaxLength)
                .IsRequired(UserEntityConstants.DescriptionRequired);
                entity
                .Property("GitHub")
                .HasMaxLength(UserEntityConstants.GitHubMaxLength)
                .IsRequired(UserEntityConstants.GitHubRequired);

                entity
                .Property("LinkedIn")
                .HasMaxLength(UserEntityConstants.LinkedInMaxLength)
                .IsRequired(UserEntityConstants.LinkedInRequired);

                entity
                .Property("Email")
                .HasMaxLength(UserEntityConstants.EmailMaxLength)
                .IsRequired(UserEntityConstants.EmailRequired);

            });
            modelBuilder.Entity<Skill>(entity => 
            {
                entity
                .HasOne(t => t.User)
                .WithMany(t => t.Skills)
                .HasForeignKey(t => t.UserId); 
                
            });
            modelBuilder.Entity<Technology>(entity => 
            {
                entity
                .Property("Name")
                .HasMaxLength(TechnologyEntityConstants.NameMaxLength)
                .IsRequired(TechnologyEntityConstants.NameRequired);

                entity
                .Property("Description")
                .HasMaxLength(TechnologyEntityConstants.DescriptionMaxLength)
                .IsRequired(TechnologyEntityConstants.DescriptionRequired);
            });
            modelBuilder.Entity<TechnologySkill>(entity => 
            {
                entity
                .HasKey(e => new { e.TechnologyId, e.SkillId });

                entity
                .HasOne(t => t.Skill)
                .WithMany(t => t.TechnologySkill)
                .HasForeignKey(t => t.SkillId);

                entity
                .HasOne(t => t.Technology)
                .WithMany(t => t.TechnologySkill)
                .HasForeignKey(t => t.TechnologyId);
            });
        }
    }
}
