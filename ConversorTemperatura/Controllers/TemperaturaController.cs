using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConversorTemperatura.Controllers
{
    public class TemperaturaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Convertir(double celsius)
        {
            // Fórmula de conversión
            double fahrenheit = (celsius * 9 / 5) + 32;

            // Pasar el resultado a la vista
            ViewBag.Fahrenheit = fahrenheit;
            ViewBag.Celsius = celsius;

            return View("Resultado");
        }
    }

}