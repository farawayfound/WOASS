using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WOASS.Models;

namespace WOASS.Controllers
{
    public class GearController : Controller
    {
        // Methods

        // Create

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Gear g)
        {
            return View();
        }
        // Read

        // Update

        // Delete
    }
}
