using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using apdb12._2.Models;
using apdb12._2.Models.requestmodels;

namespace apdb12._2.Services
{
    public class MoviesServiceImpl: IMoviesService
    {
        private readonly MovieContext _context;

        public MoviesServiceImpl(MovieContext context)
        {
            _context = context;
        }

        public IEnumerable<Movie> GetMovies()
        {
            PopulateData();
            var count = _context.Movie.Count();
            if (count == 0)
            {
                Console.WriteLine("sth");
            }
            return _context.Movie;
        }

        private void PopulateData()
        {
            _context.Movie.Add(new Movie
            {
                Genre = "some genre",
                Price = 23.2,
                Title = "some title"

            });
        }

        public Movie GetMovie(int id)
        {
            return _context.Movie.First(m => m.Id == id);
        }

        public bool AddMovie(MovieRequest request)
        {
            var newMovie = new Movie
            {
                Genre = request.Genre,
                Price = request.Price,
                Title = request.Genre,
                ReleaseDate = request.ReleaseDate
            };
            try
            {
                _context.Add(newMovie);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteMovie(int id)
        {
            try
            {
                var movie = _context.Movie.First(m => m.Id == id);
                _context.Remove(movie);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateMovie(int id, MovieRequest request)
        {
            var oldMovie = _context.Movie.First(m => m.Id == id);
            var newMovie = new Movie
            {
                Id = oldMovie.Id,
                Genre = request.Genre,
                Price = request.Price,
                Title = request.Title,
                ReleaseDate = request.ReleaseDate
            };
            try
            {
                _context.Movie.Update(newMovie);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}