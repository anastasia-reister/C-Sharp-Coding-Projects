using Code_first.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Code_first.Controllers
{
    public class HomeController : Controller
    {

        public static void Main(string[] args)
        {
            using(var ctx = new MoviesContext())
            {
                var film = new Film();
                    
                film.Name = "Lion King";
                ctx.Films.Add(film);
                ctx.SaveChanges();
                
            }
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}