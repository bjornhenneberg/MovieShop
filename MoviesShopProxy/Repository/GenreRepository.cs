using MoviesShopProxy.Context;
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
                return ctx.Genres.FirstOrDefault(item => item.Id == genreID);
            }
        }

        public void Update(Genre genre)
        {
            using (var ctx = new MovieShopContextDB())
            {
                var genreDB = ctx.Genres.FirstOrDefault(item => item.Id == genre.Id);
                genreDB.Name = genre.Name;
                genreDB.Movies = genre.Movies;
                ctx.SaveChanges();
            }
        }

        public void Delete(Genre genre)
        {
            using (var ctx = new MovieShopContextDB())
            {
                var genreDB = Read(genre.Id);
                ctx.Genres.Remove(genreDB);
                ctx.SaveChanges();
            }
        }
    }
}
