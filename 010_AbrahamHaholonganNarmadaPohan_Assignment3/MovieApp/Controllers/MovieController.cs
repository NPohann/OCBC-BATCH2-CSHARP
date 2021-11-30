using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private MovieContext _context;

        public MovieController(MovieContext context)
        {
            this._context = context;
        }

        // GET : api/User
        [HttpGet(Name = "Get All Movies")]
        public ActionResult<IEnumerable<MovieItem>> GetMovieItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            // return new string[]
            return _context.GetAllMovie();
        }

        // Get : api/user/{id}
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<IEnumerable<MovieItem>> GetMovieItem(int id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.GetMovie(id);
        }

        [HttpPost]
        public ActionResult<IEnumerable<MovieItem>> AddMovieItem(String name, String genre, String duration, DateTime releasedate)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return new JsonResult( _context.InsertMovie(name, genre, duration, releasedate));
        }

        [HttpPut]
        public ActionResult<IEnumerable<MovieItem>> UpdateMovieItem(int id, String name, String genre, String duration, DateTime releasedate)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return new JsonResult(_context.UpdateMovie(id, name, genre, duration, releasedate));
        }

        [HttpDelete]
        public ActionResult<IEnumerable<MovieItem>> DeleteMovie(int id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return new JsonResult(_context.DeleteMovie(id));
        }
    }
}
