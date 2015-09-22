using MoviesShopProxy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShopProxy
{
    public class Facade
    {
        private MovieRepository movieRepo;
        private GenreRepository genreRepo;

        public MovieRepository GetMovieRepository()
        {
            if (movieRepo == null) {
                movieRepo = new MovieRepository();
            }
            return movieRepo;
        }

        public GenreRepository GetGenreRepository()
        {
            if (genreRepo == null)
            {
                genreRepo = new GenreRepository();
            }
            return genreRepo;
        }
    }
}
