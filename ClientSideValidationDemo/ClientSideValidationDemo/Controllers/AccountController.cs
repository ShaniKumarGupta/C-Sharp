using ClientSideValidationDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientSideValidationDemo.Controllers
{
    public class AccountController : Controller
    {
        List<City> lstCity = new List<City>()
        {
            new City{CityId = 1,CName = "Pune"},
            new City{CityId = 2,CName = "Mumbai"},
            new City{CityId = 3,CName = "Nagpur"},
            new City{CityId = 4,CName = "Nashik"}
        };

        public ActionResult Register()
        {
            ViewBag.CityList = lstCity;
            return View();
        }

        [HttpPost]
        public ViewResult Register(User obj)
        {
            if (ModelState.IsValid)
                return View("Success");

            return View();
        }
    }
}