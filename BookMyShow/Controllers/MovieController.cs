using BookMyShow.Exceptions;
using BookMyShow.Models;
using BookMyShow.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookMyShow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _service;
        public MovieController(IMovieService service)
        {
            _service = service;
        }

        [HttpGet("getAllMovies")]
        public IActionResult GetMovies()
        {
            try
            {
                return Ok(_service.GetAllMovies());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("getMovieById/{id:int}")]
        public IActionResult GetMovieById(int id)
        {
            try
            {
                return Ok(_service.GetMovieById(id));
            }
            catch (MovieNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("getMovieByTitle/{title}")]
        public IActionResult GetMovieByTitle(string title)
        {
            try
            {
                return Ok(_service.GetMovieByTitle(title));
            }
            catch (MovieNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("AddMovie")]
        public IActionResult AddMovie(Movie movie)
        {
            try
            {
                return Ok(_service.AddMovie(movie));
            }
            catch (MovieAlreadyExistsException e)
            {
                return Conflict(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("removeMovie/{id:int}")]
        public IActionResult RemoveMovie(int id, Movie movie)
        {
            try
            {
                return Ok(_service.RemoveMovie(id, movie));
            }
            catch (MovieNotFoundException e)
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
