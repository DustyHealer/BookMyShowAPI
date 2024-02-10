using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Models
{
    public class ActorContext : DbContext
    {
        public ActorContext(DbContextOptions<ActorContext> options) : base(options)
        {

        }
        public DbSet<Actor> Actors { get; set; }
    }
}
