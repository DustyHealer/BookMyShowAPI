using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Models
{
    public class GenreContext : DbContext
    {
        public GenreContext(DbContextOptions<GenreContext> options) : base(options)
        {

        }
        public DbSet<Genre> Genres { get; set; }
    }
}
