using BookMyShow.Exceptions;
using BookMyShow.Models;
using BookMyShow.Repository;

namespace BookMyShow.Services
{
    public class ActorService : IActorService
    {
        private readonly IActorRepository _repo;
        public ActorService(IActorRepository repo)
        {
            _repo = repo;
        }

        public List<Actor> GetAllActors()
        {
            return _repo.GetAllActors();
        }
        public Actor GetActorById(int id)
        {
            var res = _repo.GetActorById(id);
            if (res == null)
            {
                throw new ActorNotFoundException($"Actor with Id: {id} does not exists");
            }
            return res;
        }

        public Actor GetActorByName(string name)
        {
            var res = _repo.GetActorByName(name);
            if (res == null)
            {
                throw new ActorNotFoundException($"Actor with name: {name} does not exists");
            }
            return res;
        }

        public int AddActor(Actor actor) 
        {
            var res = _repo.GetActorById(actor.ID);
            if (res != null)
            {
                throw new ActorAlreadyExistsException($"Actor with id: {actor.ID} already exists");
            }
            return _repo.AddActor(actor);
        }

        public int RemoveActor(int id, Actor actor) 
        {
            var res = _repo.GetActorById(actor.ID);
            if (res == null)
            {
                throw new ActorNotFoundException($"Actor with Id: {actor.ID} does not exists");
            }
            return _repo.RemoveActor(id, actor);
        }
    }
}
