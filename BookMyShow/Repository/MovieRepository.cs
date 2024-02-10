using BookMyShow.Models;

namespace BookMyShow.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly BookMyShowContext _dbContext;
        public MovieRepository(BookMyShowContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Movie> GetAllMovies()
        {
            return _dbContext.Movies.ToList();
        }

        public Movie? GetMovieById(int id)
        {
            return _dbContext.Movies.Where(x => x.ID.Equals(id)).FirstOrDefault();
        }

        public Movie? GetMovieByTitle(string title)
        {
            return _dbContext.Movies.Where(x => x.Title.Equals(title)).FirstOrDefault();
        }

        public int AddMovie(Movie movie)
        {
            _dbContext.Movies.Add(movie);
            return _dbContext.SaveChanges();
        }

        public int RemoveMovie(int id, Movie movie)
        {
            var res = _dbContext.Movies.Where(x => x.ID.Equals(id)).FirstOrDefault();
            _dbContext.Movies.Remove(movie);
            return _dbContext.SaveChanges();
        }
    }
}
