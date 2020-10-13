using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FizzBuzzCore.Models;
using System.Text;

namespace FizzBuzzCore.Controllers
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

        public IActionResult Solve()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Solve(string input1, string input2, string input3, string input4)
        {
            var min = Convert.ToInt32(input1);
            var max = Convert.ToInt32(input2);
            var fizz = Convert.ToInt32(input3);
            var buzz = Convert.ToInt32(input4);
            var output = new StringBuilder();
            for (int i = min; i <= max; i++)
            {
                if (i % fizz == 0 && i % buzz == 0)
                {
                    output.Append("FizzBuzz ");
                } 
                else if (i % fizz == 0)
                {
                    output.Append("Fizz ");
                } 
                else if (i % buzz == 0)
                {
                    output.Append("Buzz ");
                } 
                else
                {
                    output.AppendLine(i.ToString());
                }
            }
            ViewData["Output"] = output.ToString();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
