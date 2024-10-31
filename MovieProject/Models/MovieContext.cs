using Microsoft.EntityFrameworkCore;

namespace MovieProject.Models
{
    public class MovieContext : DbContext
    {


        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie() { MovieId = 1, Year = 2000, Name = "The God Father", Rating = 5 },
                new Movie() { MovieId = 2, Year = 1970, Name = "The Killer", Rating = 4 },
                new Movie() { MovieId = 3, Year = 1999, Name = "The Bank Robber", Rating = 3 }
                );
        }
    }
}
