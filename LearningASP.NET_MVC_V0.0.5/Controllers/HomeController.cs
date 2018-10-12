using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearningASP.NET_MVC_V0._0._5.Models;

namespace LearningASP.NET_MVC_V0._0._5.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            //ViewData["Message"] = "Hello World!";
            //ViewBag.Message = "Witaj świecie";

            //var vm = new SampleViewModel {Message = "Witaj, świecie!"};
            //return View(vm);
            List<Course> courses = new List<Course>
            {
                new Course()
                {
                    Name = "Responsive Web Desing",
                    Description = "Kurs na temat technik tworzenia stron zgodnie z ~~",
                    ImageUrl = "https://image.ceneostatic.pl/data/products/58980904/f-zimowy-poranek-nowoczesny-obraz-do-salonu.jpg"
                },
                new Course()
                {
                    Name = "Responsive Web Desing",
                    Description = "Kurs na temat technik tworzenia stron zgodnie z ~~",
                    ImageUrl = "https://image.ceneostatic.pl/data/products/58980904/f-zimowy-poranek-nowoczesny-obraz-do-salonu.jpg"
                },
                new Course()
                {
                    Name = "Responsive Web Desing",
                    Description = "Kurs na temat technik tworzenia stron zgodnie z ~~",
                    ImageUrl = "https://image.ceneostatic.pl/data/products/58980904/f-zimowy-poranek-nowoczesny-obraz-do-salonu.jpg"
                },
            };
            return View(courses);
        }

        public ActionResult LayoutSample()
        {
            return View();
        }

        public ActionResult PartialViewSample()
        {
            return View("PartialSample");
        }
    }
}