﻿using MoviesShopProxy.Context;
using MoviesShopProxy.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShopProxy.Repository
{
    public class GenreRepository
    {
        public void Add(Genre genre)
        {
            using (var ctx = new MovieShopContextDB())
            {
                //Create the queries
                ctx.Genres.Add(genre);
                //Execute the queries
                ctx.SaveChanges();
            }
        }

        public List<Genre> ReadAll()
        {
            using (var ctx = new MovieShopContextDB())
            {
                return ctx.Genres.ToList();
            }
        }

        public Genre Read(int genreID)
        {
            using (var ctx = new MovieShopContextDB())
            {
                return ctx.Genres.ToList().FirstOrDefault(item => item.Id == genreID);
            }
        }

        public void Update(Genre genre)
        {
            using (var ctx = new MovieShopContextDB())
            {
                foreach (var genreDB in ctx.Genres.ToList())
                {
                    if (genre.Id == genreDB.Id)
                    {
                        genreDB.Name = genre.Name;
                        genreDB.Movies = genre.Movies;
                        ctx.SaveChanges();
                    }
                }
            }
        }

        public void Delete(Genre genre)
        {
            using (var ctx = new MovieShopContextDB())
            {
                foreach (var genreDB in ctx.Genres.ToList())
                {
                    if (genre.Id == genreDB.Id)
                    {
                        ctx.Genres.Remove(genreDB);
                        ctx.SaveChanges();
                    }
                }
            }
        }
    }
}