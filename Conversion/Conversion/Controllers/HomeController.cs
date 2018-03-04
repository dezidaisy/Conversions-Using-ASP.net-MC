using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Conversion.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace Conversion
{
    public class HomeController : Controller
    {
        public static ConversionUnit CUnit = new ConversionUnit();
        public IActionResult Index()
        {


            return View(CUnit);
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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost("Conversion")]
        public IActionResult conversion(IFormCollection formCollection)
        {
            double number;
            if (formCollection["UnitType"] == "Metric")
            {

                Double.TryParse(formCollection["fahrenheit"], out number);
                CUnit.fahrenheit = number;
                CUnit.tcelsius();

                Double.TryParse(formCollection["feet"], out number);
                CUnit.feet = number;
                CUnit.lmeters();

                Double.TryParse(formCollection["pounds"], out number);
                CUnit.pounds = number;
                CUnit.wkg();
            }
            else
            {
                Double.TryParse(formCollection["celsius"], out number);
                CUnit.celsius = number;
                CUnit.tfahrenheit();

                Double.TryParse(formCollection["meters"], out number);
                CUnit.meters = number;
                CUnit.lfeet();

                Double.TryParse(formCollection["kg"], out number);
                CUnit.kg = number;
                CUnit.wpounds();

            }
            //formCollection["celsius"] = "abc";
            return View("Index");
        }
    }
}
