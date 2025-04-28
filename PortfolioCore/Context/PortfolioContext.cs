using Microsoft.EntityFrameworkCore;
using PortfolioCore.Entities;

namespace PortfolioCore.Context
{
    public class PortfolioContext : DbContext
    {

        public DbSet<Contact>Contacts {get ; set;}
        public DbSet<Education> Educations { get ; set;}
        public DbSet<Experience> Experiences { get ; set;}
        public DbSet<Message> Messages { get ; set;}
        public DbSet<Testimonial> Testimonials { get ; set;}
        public DbSet<Skill> Skills { get ; set;}
        public DbSet<Category> Categories { get ; set;}
        public DbSet<Portfolio> Portfolios { get ; set;}
        public DbSet<SocialMedia> SocialMedias { get ; set;}
        public DbSet<About> Abouts { get ; set;}
        public DbSet<Service> Services { get ; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOPCENG\\SQLEXPRESS;Initial Catalog=PortfolioNightDb;Integrated Security=True; ");
        }
    }
}
