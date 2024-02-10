using BookMyShow.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly GenreContext _dbContext;
        public GenreController(GenreContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Genre>>> GetGenres()
        {
            if (_dbContext.Genres == null)
            {
                return NotFound();
            }
            return await _dbContext.Genres.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Genre>> GetGenreById(int id)
        {
            if (_dbContext.Genres == null)
            {
                return NotFound();
            }

            var genre = await _dbContext.Genres.FindAsync(id);
            if (genre == null)
            {
                return NotFound();
            }
            return genre;
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<Genre>> GetGenreByName(string name)
        {
            if (_dbContext.Genres == null)
            {
                return NotFound();
            }

            var genre = await _dbContext.Genres.FindAsync(name);
            if (genre == null)
            {
                return NotFound();
            }
            return genre;
        }
    }
}
