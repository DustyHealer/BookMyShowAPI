using BookMyShow.Exceptions;
using BookMyShow.Models;
using BookMyShow.Repository;

namespace BookMyShow.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _repo;
        public MovieService(IMovieRepository repo)
        {
            _repo = repo;
        }

        public List<Movie> GetAllMovies()
        {
            return _repo.GetAllMovies();
        }

        public Movie GetMovieById(int id)
        {
            var res = _repo.GetMovieById(id);
            if (res == null)
            {
                throw new MovieNotFoundException($"Movie with Id: {id} does not exists");
            }
            return res;
        }

        public Movie GetMovieByTitle(string title)
        {
            var res = _repo.GetMovieByTitle(title);
            if (res == null)
            {
                throw new MovieNotFoundException($"Movie with title: {title} does not exists");
            }
            return res;
        }
        public int AddMovie(Movie movie)
        {
            var res = _repo.GetMovieByTitle(movie.Title);
            if (res != null)
            {
                throw new MovieAlreadyExistsException($"Movie with id: {movie.Title} already exists");
            }
            return _repo.AddMovie(movie);
        }

        public int RemoveMovie(int id, Movie movie)
        {
            var res = _repo.GetMovieById(id);
            if (res == null)
            {
                throw new MovieNotFoundException($"Movie with Id: {id} does not exists");
            }
            return _repo.RemoveMovie(id, movie);
        }
    }
}
