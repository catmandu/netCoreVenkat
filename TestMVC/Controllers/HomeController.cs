using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Person model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Data", model);
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Data(Person model)
        {
            return View(model);
        }
    }
}