using CleanMovie.Application.Interfaces;
using CleanMovie.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanMovie.WebAppi.Controllers
{
    
   // [Route("[controller]/[action]")]
    [Route("api/[controller]")]
    [ApiController]

    public class MoviesController : Controller
    {
        // GET: MoviesController

        private readonly IMovieServices _movieServices;
        
        public MoviesController( IMovieServices movieServices)
        {
            _movieServices = movieServices;

        }

        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {

            var moviesFromServers = _movieServices.GetAllMovies();
            return Ok(moviesFromServers);
        }

        

       

        
       

       

        
    }
}
