using Mission6_Johnson.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace Mission6_Johnson.Models
{
    public class AddMoviesContext : DbContext
    {
        public AddMoviesContext(DbContextOptions<AddMoviesContext> options) : base(options) //contructor
        {
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
