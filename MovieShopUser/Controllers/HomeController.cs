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

        public ActionResult Index()
        {
            
            return View(facade.GetMovieRepository().ReadAll());
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            Movie movie = facade.GetMovieRepository().Read(id);
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