using MovieShopDAL;
using MovieShopDAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
namespace MovieShopRest.Controllers
{
    public class MovieController : ApiController
    {
        private Facade facade = new Facade();
        public IEnumerable<Movie> GetMovies()
        {
            return new Facade().GetMovieRepository().ReadAll();
        }

    }
}
