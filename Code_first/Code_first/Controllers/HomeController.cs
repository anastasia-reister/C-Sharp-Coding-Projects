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
      
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult directorInfo(string firstName, string lastName, string country)
        {
            using (var ctx = new Movies())
            {
                var director = new Director();

                director.FirstName = firstName;
                director.LastName = lastName;
                director.Country = country;

                ctx.Directors.Add(director);
                ctx.SaveChanges();

                return View("Index");

            }
        }

    

            

        public ActionResult Directors()
        {
            
                using (var db = new Movies())
                {
                    return View(db.Directors.ToList());
                }
            

            
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}