using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Models
{
    public class DirectorContext : DbContext
    {
        public DirectorContext(DbContextOptions<DirectorContext> options) : base(options)
        {
            
        }
        public DbSet<Director> Directors { get; set; }
    }
}
