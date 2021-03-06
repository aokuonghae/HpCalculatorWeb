﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HpCalculatorWeb.Controllers
{
    public class HpController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<SelectListItem> myLevel = new List<SelectListItem>(Enumerable.Range(0, 21)
            .Select(p => new SelectListItem() { Text = p.ToString(), Value = p.ToString() }));
            ViewData["MyLevel"] = myLevel;
            return View();
        }

        [HttpPost]
        [Route("/hp")]
        public IActionResult GetHp(int MyLevel)
        {
            ViewBag.level = MyLevel;
            return View();
        }
    }
}
