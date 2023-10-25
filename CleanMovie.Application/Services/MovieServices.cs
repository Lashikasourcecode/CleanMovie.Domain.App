using CleanMovie.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application.Services
{
    public class MovieServices:IMovieServices
    {

        public readonly IMovieRepository _movieRepository;
        public MovieServices(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public List<Domain.Movie> GetAllMovies()
        {
            var movies = _movieRepository.GetAllMovies();
            return movies;
        }

    }
}
