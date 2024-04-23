using Ex_Cours11.Models;
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
            return View();
        }

        [HttpPost]
        public IActionResult Index(String Name)
        {
            return View();
        }

        public IActionResult List()
        {
            return View(DB.Dragons.ToList());
        }

        public IActionResult Cart()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Cart(int Id)
        {
            return View();
        }
    }
}
