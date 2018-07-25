using ecotour2018.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ecotour2018.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactModel contact)
        {
            ViewBag.Message = contact.Email;

            return View();
        }

        public ActionResult Countries()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Tours(string id)
        {
            var tours = new List<Tour>();
            tours.Add(new Tour
            {
                Data = "25.07.2018",
                Country = "Польша",
                Price = 6000
            });
            tours.Add(new Tour
            {
                Data = "30.07.2018",
                Country = "Турция",
                Price = 5000
            });
            tours.Add(new Tour
            {
                Data = "31.07.2018",
                Country = "США",
                Price = 16000
            });
            tours.Add(new Tour
            {
                Data = "29.07.2018",
                Country = "Таиланд",
                Price = 15000
            });

            if (!string.IsNullOrEmpty(id))
                return View(tours.Where(c=>c.Country.StartsWith(id)));
            else
                return View(tours);
        }
    
    }
}