using Microsoft.AspNetCore.Mvc;
using Repositories.Repositories;

namespace Movies.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {   

        /// <summary>
        /// Dependency Injection
        /// </summary>
        public readonly MovieRepository _repository;

        public MoviesController(MovieRepository movieRepository)
        {
            _repository = movieRepository;
        }
        

        [HttpGet]
        public async Task<IActionResult> Get(string id) => Ok();

        //[HttpPost]
        //public async Task<IActionResult> Post(AddMovie addMovie)
        //{
        // //   var result =_repository.Add(addMovie);
        //   // return Ok(result);
        //}

        [HttpPost("DeleteById/{id}")]
        public IActionResult DeleteById(int it)
        {
            _repository.DeleteMovieById(it);
            return Ok();
        }


        
        
    }
}
