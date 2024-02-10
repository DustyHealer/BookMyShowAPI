using BookMyShow.Models;

namespace BookMyShow.Repository
{
    public class ActorRepository : IActorRepository
    {
        private readonly BookMyShowContext _dbContext;
        public ActorRepository(BookMyShowContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Actor> GetAllActors()
        {
            return _dbContext.Actors.ToList();
        }

        public Actor? GetActorById(int id) 
        {
            return _dbContext.Actors.Where(x => x.ID.Equals(id)).FirstOrDefault();
        }

        public Actor? GetActorByName(string name)
        {
            return _dbContext.Actors.Where(x => x.Name.Equals(name)).FirstOrDefault();
        }

        public int AddActor(Actor actor) 
        {
            _dbContext.Actors.Add(actor);
            return _dbContext.SaveChanges();
        }

        public int RemoveActor(int id, Actor actor) 
        {
            var res = _dbContext.Actors.Where(x => x.ID.Equals(id)).FirstOrDefault();
            _dbContext.Actors.Remove(actor);
            return _dbContext.SaveChanges();
        }
    }
}
