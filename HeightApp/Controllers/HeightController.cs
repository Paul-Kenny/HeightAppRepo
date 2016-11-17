using HeightApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HeightApp.Controllers
{
    public class HeightController : Controller
    {
        // GET: Convert
        [HttpGet]
        public ActionResult Convert()
        {
            //Height h = new Height { Feet = 0, Inches = 0 };
            // return View(h);
            return View();
        }

        [HttpPost]
        // GET: Convert
        public ActionResult Convert(Height n)
        {                  
            return View(n);
        }


    }
}