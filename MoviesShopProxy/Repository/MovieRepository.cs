using MoviesShopProxy.Context;
using MoviesShopProxy.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShopProxy.Repository
{
    public class MovieRepository
    {
        public void Add(Movie movie) {
            using (var ctx = new MovieShopContextDB())
            {
                //Create the queries
                ctx.Movies.Add(movie);
                //Execute the queries
                ctx.SaveChanges();
            }
        }

        public List<Movie> ReadAll()
        {
            using (var ctx = new MovieShopContextDB())
            {
                return ctx.Movies.Include("Genre").ToList();
            }
        }

        public Movie Read(int movieID)
        {
            using (var ctx = new MovieShopContextDB())
            {
                return ctx.Movies.FirstOrDefault(item => item.Id == movieID);
            }
        }

        public void Update(Movie movie)
        {
            using (var ctx = new MovieShopContextDB())
            {
                foreach (var movieDB in ctx.Movies.ToList())
                {
                    if(movie.Id == movieDB.Id)
                    {
                        movieDB.Genre = movie.Genre;
                        movieDB.imageURL = movie.imageURL;
                        movieDB.Price = movie.Price;
                        movieDB.Title = movie.Title;
                        movieDB.trailerURL = movie.trailerURL;
                        movieDB.Year = movie.Year;
                        ctx.SaveChanges();
                    }
                }
            }
        }

        public void Delete(Movie movie)
        {
            using (var ctx = new MovieShopContextDB())
            {
                foreach (var movieDB in ctx.Movies.ToList())
                {
                    if (movie.Id == movieDB.Id)
                    {
                        ctx.Movies.Remove(movieDB);
                        ctx.SaveChanges();
                    }
                }
            }
        }

    }
}
