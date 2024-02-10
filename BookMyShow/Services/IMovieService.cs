using BookMyShow.Models;

namespace BookMyShow.Services
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
        Movie GetMovieById(int id);
        Movie GetMovieByTitle(string title);
        public int AddMovie(Movie movie);
        public int RemoveMovie(int id, Movie movie);
    }
}
