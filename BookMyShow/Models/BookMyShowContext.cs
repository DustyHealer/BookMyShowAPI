using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Models
{
    public class BookMyShowContext : DbContext
    {
        public BookMyShowContext(DbContextOptions<BookMyShowContext> options) : base(options)
        {

        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
