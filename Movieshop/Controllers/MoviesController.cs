using Movieshop.Models.ViewModels;
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
            MovieViewModel viewModel = new MovieViewModel()
            {
                Genres = facade.GetGenreRepository().ReadAll().ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            movie.Genre = facade.GetGenreRepository().Read(movie.Genre.Id);

            facade.GetMovieRepository().Add(movie);
            return Redirect("Index");
        }

        [HttpGet]
        public ActionResult Update(int Id)
        {
            MovieViewModel viewModel = new MovieViewModel()
            {
                Movie = facade.GetMovieRepository().Read(Id),
                Genres = facade.GetGenreRepository().ReadAll()
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Update([Bind(Include="Id,ImageUrl,TrailerUrl")] Movie movie)
        {
            movie.Genre = facade.GetGenreRepository().Read(movie.Genre.Id);
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