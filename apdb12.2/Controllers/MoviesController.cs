using apdb12._2.Models.requestmodels;
using apdb12._2.Services;
using Microsoft.AspNetCore.Mvc;

namespace apdb12._2.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;

        
        public MoviesController(IMoviesService service)
        {
            _service = service;
        }

        // GET
        public IActionResult Index()
        {
            var movies = _service.GetMovies();
            return View(movies);
        }
        [HttpPost]
        public IActionResult AddMovie(MovieRequest request)
        {
            var success = _service.AddMovie(request);
            if (success) return Ok();
            else return BadRequest();
        }
        [HttpPost]
        public IActionResult UpdateMovie(int id, MovieRequest request)
        {
            var success = _service.UpdateMovie(id, request);
            if (success) return Ok();
            else return BadRequest();
        }
        [HttpDelete]
        public IActionResult DeleteMovie(int id)
        {
            var success = _service.DeleteMovie(id);
            if (success) return Ok();
            else return BadRequest();
        }
        [HttpGet]
        public IActionResult GetMovie(int id)
        {
            var movie = _service.GetMovie(id);
            if (movie == null) return NotFound();
            else return View(movie);
        }
        
    }
}