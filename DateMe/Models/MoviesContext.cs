using Microsoft.EntityFrameworkCore;

namespace Mission06_Nance.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options) //Constructor
        {

        }
        public DbSet<Application> Applications { get; set; }
    }
}
