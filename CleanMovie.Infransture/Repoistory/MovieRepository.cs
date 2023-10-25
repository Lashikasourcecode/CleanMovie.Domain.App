using CleanMovie.Application.Interfaces;
using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infransture.Repoistory
{
    public class MovieRepository:IMovieRepository
    {
        public static List<Movie> movies = new List<Movie>()
        {
            new Movie{Id = 1, Name ="Passion of chrst", Price= 100 },
            new Movie{Id =2, Name="Titanic", Price= 200 },
            new Movie{Id =3, Name ="Home Alone", Price=300},
            new Movie{Id =4, Name="Test2", Price=400}

        };

       public List<Movie> GetAllMovies()
        {
            return movies;
        }

    }
}
