using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloAgainWeb.Models;

namespace HelloAgainWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult FredrikHaglund()
        {
            return View();
        }
        public IActionResult EliasMohammed()
        {
            return View();
        }
        public IActionResult Uttern()
        {
            return View();
        }

        public IActionResult TomasUtanH()
                {
            return View();
        }

        public IActionResult GustavWestberg()
        {
            return View();
        }

        public IActionResult Ahmad()
        {
            return View();
        }

        public IActionResult HelenaOchFeyona()
        {
            return View();
        }

        public IActionResult GustavCleveman()
        {
            return View();
        }

        public IActionResult Samulf()
        {
            return View();
        }

        public IActionResult Kalle()
        {
            return View();
        }
        
        public IActionResult JohannaAkerstrom()
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
