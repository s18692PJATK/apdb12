using System.Collections;
using System.Collections.Generic;
using apdb12._2.Models;
using apdb12._2.Models.requestmodels;

namespace apdb12._2.Services
{
    public interface IMoviesService
    {
        public Movie GetMovie(int id);
        public bool AddMovie(MovieRequest request);
        public bool DeleteMovie(int id);
        public bool UpdateMovie(int id, MovieRequest request);
        public IEnumerable<Movie> GetMovies();
    }
}