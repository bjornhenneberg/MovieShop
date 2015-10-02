using MoviesShopProxy.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movieshop.Models.ViewModels
{
    public class MovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Genre> Genres { get; set; }
        public MovieViewModel()
        {
            Genres = new List<Genre>();
        }
    }
}