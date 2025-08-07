using Microsoft.EntityFrameworkCore;
using MyPortfolio.DAL.Entities;
namespace MyPortfolio.DAL.Context
{
    public class MyPortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=FURKAN\\SQLEXPRESS; Initial Catalog=MyPortfolioDB; Integrated Security=true; TrustServerCertificate=True;");
        }
        public DbSet<About> Abouts { get; set; } 
        public DbSet<Contact> Contacts { get; set; } 
        public DbSet<Experience> Experiences { get; set; } 
        public DbSet<Feature> Features { get; set; } 
        public DbSet<Message> Messages { get; set; } 
        public DbSet<Project> Projects { get; set; } 
        public DbSet<Skill> Skills { get; set; } 
        public DbSet<Social> Socials { get; set; } 
    }
}
