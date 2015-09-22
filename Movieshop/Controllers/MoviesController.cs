using MoviesShopProxy;
using MoviesShopProxy.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movieshop.Controllers
{
    public class MoviesController : Controller
    {
        private Facade facade = new Facade();
        // GET: Movies
        public ActionResult Index()
        {
            List<Movie> movies = facade.GetMovieRepository().ReadAll();
            return View(movies);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            facade.GetMovieRepository().Add(movie);
            return Redirect("Index");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            Movie movie = facade.GetMovieRepository().Read(id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Update(Movie movie)
        {
            facade.GetMovieRepository().Update(movie);
            return Redirect("~/Movies/Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Movie movie = facade.GetMovieRepository().Read(id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Delete(Movie movie)
        {
            facade.GetMovieRepository().Delete(movie);
            return Redirect("~/Movies/Index");
        }
    }
}