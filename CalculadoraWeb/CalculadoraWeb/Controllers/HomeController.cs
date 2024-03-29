﻿using CalculadoraWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CalculadoraWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Calculation cal)
        {
            decimal a, b;
            a = cal.Value1;
            b = cal.Value2;

            switch (cal.Calculate)
            {
                case "+":
                    cal.Result = a + b;
                    break;
                case "-":
                    cal.Result = a - b;
                    break;
                case "*":
                    cal.Result = a * b;
                    break;
                case "/":
                    cal.Result = a / b;
                    break;
                default:
                    throw new ArgumentException();
            }
            ViewData["Result"] = cal.Result;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}