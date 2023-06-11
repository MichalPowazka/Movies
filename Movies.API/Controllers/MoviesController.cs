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

        /// <summary>
        /// Dependency Injection
        /// </summary>
        public readonly IMoviesService _moviesService;

        public MoviesController(IMoviesService moviesService)
        {
            _moviesService = moviesService;
        }


        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(_moviesService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddMovie addMovie)
        {
            var result = _moviesService.Add(addMovie);
            return Ok(result);
        }
        [HttpPatch]
        public async Task<IActionResult> Put(UpdateMovie updateMovie)
        {
            var result = _moviesService.Update(updateMovie);
            return Ok(result);
        }

        [HttpDelete("DeleteById/{id}")]
       

        public async Task<IActionResult> Delete(int id)
        {
            _moviesService.DeleteById(id);
            return Ok();
            //ok
            
        }



    }
}
