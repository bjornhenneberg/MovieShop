﻿using MoviesShopProxy.Context;
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

        public Movie Read(int movieId)
        {
            using (var ctx = new MovieShopContextDB())
            {
                return ctx.Movies.FirstOrDefault(item => item.Id == movieId);
            }
        }

        public void Update(Movie movie)
        {
            using (var ctx = new MovieShopContextDB())
            {
                var movieDB = ctx.Movies.FirstOrDefault(item => item.Id == movie.Id);
                movieDB.Genre = ctx.Genres.FirstOrDefault(x => x.Id == movie.Genre.Id);
                movieDB.imageURL = movie.imageURL;
                movieDB.Price = movie.Price;
                movieDB.Title = movie.Title;
                movieDB.trailerURL = movie.trailerURL;
                movieDB.Year = movie.Year;
                ctx.SaveChanges();
            }
        }

        public void Delete(Movie movie)
        {
            using (var ctx = new MovieShopContextDB())
            {
                var movieDB = ctx.Movies.FirstOrDefault(item => item.Id == movie.Id);
                ctx.Movies.Remove(movieDB);
                ctx.SaveChanges();
            }
        }

    }
}
