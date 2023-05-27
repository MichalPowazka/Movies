using Microsoft.AspNetCore.Mvc;
using Movies.API.DTO.Movies;
using Movies.Services.Interfaces;

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
        public async Task<IActionResult> Get(string id) => Ok();

        [HttpPost]
        public async Task<IActionResult> Post(AddMovie addMovie)
        {
            var result =_moviesService.Add(addMovie);
            return Ok(result);
        }


        
        
    }
}
