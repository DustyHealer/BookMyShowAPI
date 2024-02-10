using BookMyShow.Models;

namespace BookMyShow.Services
{
    public interface IGenreService
    {
        List<Genre> GetAllGenres();
        Genre GetGenreById(int id);
        Genre GetGenreByName(string name);
        public int AddGenre(Genre genre);
        public int RemoveGenre(int id, Genre genre);
    }
}
