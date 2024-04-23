﻿using Ex_Cours11.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_Cours11.Controllers
{
    public class DragonController : Controller
    {
        private Database DB;
        public DragonController(Database dB)
        {
            DB = dB;
        }

        public IActionResult Index()
        {
            String name = HttpContext.Session.GetString("Name");
            if (name != null)
                ViewData["name"] = name;
            return View();
        }

        [HttpPost]
        public IActionResult Index(String Name)
        {
            HttpContext.Session.SetString("Name", Name);
            ViewData["name"] = HttpContext.Session.GetString("Name");
            return View();
        }

        public IActionResult List()
        {
            return View(DB.Dragons.ToList());
        }

        public IActionResult Cart()
        {
            List<Dragon> dragons = HttpContext.Session.Get<List<Dragon>>("dragons");
            return View(dragons);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Cart(int Id)
        {
            List<Dragon> dragons = HttpContext.Session.Get<List<Dragon>>("dragons");

            if (dragons == null)
            {
                dragons = new List<Dragon>();
            }

            dragons.Add(DB.Dragons.Where(d => d.Id == Id).Single());
            HttpContext.Session.Set<List<Dragon>>("dragons", dragons);

            return View(dragons);
        }

        public IActionResult Redirections()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Redirections(int Id)
        {
            if (Id == 1)
            {
                return View("Arrival");
            }
            else
            {
                return RedirectToAction("Arrival", "Dragon", new { value = 2 });
            }
        }

        public IActionResult Arrival(int? value)
        {
            return View(value);
        }
    }
}
