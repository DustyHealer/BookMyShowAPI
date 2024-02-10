using BookMyShow.Models;

namespace BookMyShow.Repository
{
    public interface IActorRepository
    {
        List<Actor> GetAllActors();
        Actor? GetActorById(int id);
        Actor? GetActorByName(string name);
        int AddActor(Actor actor);
        int RemoveActor(int id, Actor actor);
    }
}
