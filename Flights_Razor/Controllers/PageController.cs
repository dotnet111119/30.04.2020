using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3004_.Models;

namespace WebApplication3004_.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        public ActionResult Index()
        {
            return new FilePathResult("~/Views/Page/index.html", "text/html");
        }

        public ActionResult Landing()
        {
            // get anonymous facade
            // execute:  anfacade.GetAllFlights() -- List<Flight>
            List<Flight> flights = new List<Flight>()
            {
                new Flight { Id = 1, From="Israel", To = "France", Remaining = 1, Pic="../../Content/elal.png"},
                new Flight { Id = 3, From="Turkey", To = "Japan", Remaining = 9, Pic="../../Content/elal.png"},
                new Flight { Id = 5, From="New York", To = "Toronto", Remaining = 3, Pic="../../Content/elal.png"},
                new Flight { Id = 9, From="Greece", To = "Hong Kong", Remaining = 10, Pic="../../Content/elal.png"},
            };
            ViewBag.Flights = flights;
            return View();
        }

        public ActionResult Select()
        {
            // get anonymous facade
            // execute:  get all countries

            List<string> countries = new List<string> { "Israel", "Turkey", "Japan", "Hong Kong" };

            ViewBag.Countries = countries;
            return View();
        }

        public ActionResult Docserver()
        {
            // name="idtxt"
            // name="emailtxt"
            // name="pwd"
            // name="bdate"
            // name="gender"
            // name="country"
            // name="vegetarian" 

            ViewBag.idtxt = Request.Form["idtxt"];
            if (ViewBag.idtxt == null)
                ViewBag.idtxt = Request.QueryString["idtxt"]; // query is for GET method

            ViewBag.emailtxt = Request.Form["emailtxt"];
            ViewBag.pwd = Request.Form["pwd"];
            ViewBag.bdate = Request.Form["bdate"];
            ViewBag.gender = Request.Form["gender"];
            ViewBag.country = Request.Form["country"];
            ViewBag.vegetarian = Request.Form["vegetarian"];

            return View();
        }
    }
}