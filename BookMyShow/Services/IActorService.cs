using BookMyShow.Models;

namespace BookMyShow.Services
{
    public interface IActorService
    {
        List<Actor> GetAllActors();
        Actor GetActorById(int id);
        Actor GetActorByName(string name);
        public int AddActor(Actor actor);
        public int RemoveActor(int id, Actor actor);
    }
}
