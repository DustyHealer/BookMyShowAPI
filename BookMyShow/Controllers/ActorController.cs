using BookMyShow.Exceptions;
using BookMyShow.Models;
using BookMyShow.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookMyShow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IActorService _service;
        public ActorController(IActorService service)
        {
            _service = service;
        }

        [HttpGet("getAllActors")]
        public IActionResult GetActors()
        {
            try
            {
                return Ok(_service.GetAllActors());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("getActorById/{id:int}")]
        public IActionResult GetActorById(int id)
        {
            try
            {
                return Ok(_service.GetActorById(id));
            }
            catch (ActorNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("getActorByName/{name}")]
        public IActionResult GetActorByName(string name)
        {
            try
            {
                return Ok(_service.GetActorByName(name));
            }
            catch (ActorNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("AddActor")]
        public IActionResult Addbooking(Actor actor)
        {
            try
            {
                return Ok(_service.AddActor(actor));
            }
            catch (ActorAlreadyExistsException e)
            {
                return Conflict(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("removeActor/{id:int}")]
        public IActionResult RemoveActor(int id, Actor actor)
        {
            try
            {
                return Ok(_service.RemoveActor(id, actor));
            }
            catch (ActorNotFoundException e)
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
