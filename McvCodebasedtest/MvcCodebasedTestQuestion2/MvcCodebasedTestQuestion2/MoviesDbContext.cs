using System.Data.Entity;

namespace MvcCodebasedTestQuestion2.Models
{
    public class MoviesDbContext :DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}