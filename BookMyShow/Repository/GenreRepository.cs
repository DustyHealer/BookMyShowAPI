using BookMyShow.Models;

namespace BookMyShow.Repository
{
    public class GenreRepository : IGenreRepository
    {
        private readonly BookMyShowContext _dbContext;
        public GenreRepository(BookMyShowContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Genre> GetAllGenres()
        {
            return _dbContext.Genres.ToList();
        }

        public Genre? GetGenreById(int id)
        {
            return _dbContext.Genres.Where(x => x.ID.Equals(id)).FirstOrDefault();
        }

        public Genre? GetGenreByName(string name)
        {
            return _dbContext.Genres.Where(x => x.Name.Equals(name)).FirstOrDefault();
        }

        public int AddGenre(Genre genre)
        {
            _dbContext.Genres.Add(genre);
            return _dbContext.SaveChanges();
        }

        public int RemoveGenre(int id, Genre genre)
        {
            var res = _dbContext.Genres.Where(x => x.ID.Equals(id)).FirstOrDefault();
            _dbContext.Genres.Remove(genre);
            return _dbContext.SaveChanges();
        }
    }
}
