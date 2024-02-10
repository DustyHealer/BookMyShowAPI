using BookMyShow.Models;

namespace BookMyShow.Repository
{
    public interface IGenreRepository
    {
        List<Genre> GetAllGenres();
        Genre? GetGenreById(int id);
        Genre? GetGenreByName(string name);
        int AddGenre(Genre genre);
        int RemoveGenre(int id, Genre genre);
    }
}
