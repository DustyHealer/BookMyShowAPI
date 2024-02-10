using BookMyShow.Exceptions;
using BookMyShow.Models;
using BookMyShow.Repository;

namespace BookMyShow.Services
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _repo;
        public GenreService(IGenreRepository repo)
        {
            _repo = repo;
        }

        public List<Genre> GetAllGenres()
        {
            return _repo.GetAllGenres();
        }

        public Genre GetGenreById(int id)
        {
            var res = _repo.GetGenreById(id);
            if (res == null)
            {
                throw new GenreNotFoundException($"Genre with Id: {id} does not exists");
            }
            return res;
        }

        public Genre GetGenreByName(string name)
        {
            var res = _repo.GetGenreByName(name);
            if (res == null)
            {
                throw new GenreNotFoundException($"Actor with name: {name} does not exists");
            }
            return res;
        }

        public int AddGenre(Genre genre)
        {
            var res = _repo.GetGenreByName(genre.Name);
            if (res != null)
            {
                throw new GenreAlreadyExistsException($"Genre with name: {genre.Name} already exists");
            }
            return _repo.AddGenre(genre);
        }

        public int RemoveGenre(int id, Genre genre)
        {
            var res = _repo.GetGenreById(genre.ID);
            if (res == null)
            {
                throw new GenreNotFoundException($"Genre with Id: {genre.ID} does not exists");
            }
            return _repo.RemoveGenre(id, genre);
        }
    }
}
