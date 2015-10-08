using MoviesShopProxy;
using MoviesShopProxy.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieShopUser.Controllers
{
    public class HomeController : Controller
    {

        Facade facade = new Facade();

        public ActionResult Index(int? genreId, string searchString = "")
        {
            
            var movies = facade.GetMovieRepository().ReadAll();

            if (genreId.HasValue)
            {
                movies = movies.Where(x => x.Genre.Id == genreId.Value).ToList();
            }

            if (searchString != "")
            {
                movies = movies.Where(x => x.Title.ToLower().Contains(searchString.ToLower())).ToList();
            }

            return View(movies);
        }

        public ActionResult GenreDropDown()
        {
            var genres = facade.GetGenreRepository().ReadAll().ToList();

            return PartialView(genres);
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            var movie = facade.GetMovieRepository().Read(id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Buy(Order order)
        {
            return Redirect("Index");
        }
        public ActionResult Info(int id)
        {
            return View(facade.GetMovieRepository().Read(id));
        }
    }
}