using BookMyShow.Models;

namespace BookMyShow.Repository
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();
        Movie? GetMovieById(int id);
        Movie? GetMovieByTitle(string title);
        int AddMovie(Movie movie);
        int RemoveMovie(int id, Movie movie);
    }
}
