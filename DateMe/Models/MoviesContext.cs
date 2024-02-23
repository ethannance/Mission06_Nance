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


    }
}
