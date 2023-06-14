using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Movies.API.DTO.Movies;
using Movies.Services.Interfaces;
using System.Linq;

namespace Movies.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        public readonly IMoviesService _moviesService;

        public MoviesController(IMoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                return Ok(await _moviesService.GetById(id));
            }
            catch (Exception)
            {
                return NotFound("This record does not exist");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddMovie addMovie)
        {
            var result =_moviesService.Add(addMovie);
            return Ok(result);
        }

        [HttpPatch]
        public async Task<IActionResult> Put(UpdateMovie updateMovie)
        {
            var result = await _moviesService.Update(updateMovie);
            return Ok(result);
        }

        [HttpDelete("DeleteById/{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            _moviesService.Delete(id);
            return Ok();
            
        }



    }
}
