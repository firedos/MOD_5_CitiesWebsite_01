﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//
using CitiesWebsite.Services;


namespace CitiesWebsite.Controllers
{
    public class CityesController : Controller
    {
        private ICityProvider _cities;
        public CityesController(ICityProvider c)
        {
            _cities = c;
        }

        public IActionResult ShowCities()
        {
            ViewBag.Cities = _cities;
            return View();
        }

        public IActionResult ShowDataForCity(string cityName)
        {
            ViewBag.City = _cities[cityName];
            return View();
        }

        public IActionResult GetImage(string cityName)
        {
            //return Content(cityName);
            return File($@"images2\{cityName}.jpg", "image/jpeg");
        }
    }
}