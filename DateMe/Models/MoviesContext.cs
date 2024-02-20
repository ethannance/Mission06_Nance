using Microsoft.EntityFrameworkCore;

namespace Mission06_Nance.Models
{
    public class MoviesContext : DbContext //Liaison from app to database
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options) //Constructor
        {

        }
        public DbSet<Application> Movies { get; set; }
        public DbSet<CategoryCategory> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //Seed data
        {
            modelBuilder.Entity<CategoryCategory>().HasData(

                new CategoryCategory { CategoryId = 1, Category= "Miscellaneous"},
                new CategoryCategory { CategoryId = 2, Category = "Drama" },
                new CategoryCategory { CategoryId = 3, Category = "Television" },
                new CategoryCategory { CategoryId = 4, Category = "Horror/Suspense" },
                new CategoryCategory { CategoryId = 5, Category = "Comedy" },
                new CategoryCategory { CategoryId = 6, Category = "Family" },
                new CategoryCategory { CategoryId = 7, Category = "Action/Adventure" },
                new CategoryCategory { CategoryId = 8, Category = "VHS" }
                );
        }
    }
}
