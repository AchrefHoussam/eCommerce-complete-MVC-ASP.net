using Microsoft.EntityFrameworkCore;
using System.Drawing;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppDbContext : DbContext
    {
        protected AppDbContext(DbContextOptions<DbContext> options) : base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie_Actor>().HasKey(
            am => new
            {
                am.ActorId ,  am.MovieId
            }) ;

            modelBuilder.Entity<Movie_Actor>()
                        .HasOne(m => m.Movie)
                        .WithMany(am => am.Movie_Actor)
                        .HasForeignKey(m => m.MovieId);
            
            modelBuilder.Entity<Movie_Actor>()
                        .HasOne(m => m.Actor)
                        .WithMany(am => am.Movie_Actor)
                        .HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder);

    }

        public DbSet<Actor> Actor    { get;set; }
        public DbSet<Movie> Movie    { get;set; }
        public DbSet<Producer> Producer { get;set; }    
        public DbSet<Cinema> Cinema { get;set; }    
        public DbSet<Movie_Actor> Actor_Actor { get;set; }  
    }
}
