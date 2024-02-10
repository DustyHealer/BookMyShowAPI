using BookMyShow.Exceptions;
using BookMyShow.Models;
using BookMyShow.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookMyShow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService _service;
        public GenreController(IGenreService service)
        {
            _service = service;
        }

        [HttpGet("getAllGenres")]
        public IActionResult GetGenres()
        {
            try
            {
                return Ok(_service.GetAllGenres());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("getGenreById/{id:int}")]
        public IActionResult GetGenreById(int id)
        {
            try
            {
                return Ok(_service.GetGenreById(id));
            }
            catch (GenreNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("getGenreByName/{name}")]
        public IActionResult GetGenreByName(string name)
        {
            try
            {
                return Ok(_service.GetGenreByName(name));
            }
            catch (GenreNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("AddGenre")]
        public IActionResult AddGenre(Genre genre)
        {
            try
            {
                return Ok(_service.AddGenre(genre));
            }
            catch (GenreAlreadyExistsException e)
            {
                return Conflict(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("removeGenre/{id:int}")]
        public IActionResult RemoveGenre(int id, Genre genre)
        {
            try
            {
                return Ok(_service.RemoveGenre(id, genre));
            }
            catch (GenreNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
