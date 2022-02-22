using CalculatorWeb.Models;
using CalculatorWeb.Bussines;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CalculatorWeb.Services;

namespace CalculatorWeb.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Suma(Datos datos)
        {
            //Por si queremos validar que los datos sean 'correctos'
            if (datos.num1 < 0 || datos.num2 > 1000000000000)
            {
                return View("Error");
            }

            //¿Dudas con las Interface?
            //IOperaciones op = new Operaciones();
            //IOperaciones opW = new I_Hate_Math();
            //Double goodResult = op.suma(datos);
            //Double badResult = opW.suma(datos);

            //Usamos un objeto de la clase Operaciones para realizar la suma,
            //como Operaciones extiende de IOperaciones, sabemos que contiene
            //los cuatro métodos de las operaciones matemáticas.
            //Para este caso usaremos el método de suma.
            Operaciones operaciones = new Operaciones();
            //Almacenamos el resultado en una variable.
            Double result = operaciones.suma(datos);

            //Enviamos los datos desde el Controller hasta la View
            ViewBag.num1 = datos.num1;
            ViewBag.num2 = datos.num2;
            ViewBag.ResultAddition = result;

            //Nos dirigimos a la View correspondiente a la Suma
            return View();
        }

        public IActionResult Resta(Datos datos)
        {

            if (datos.num1 < 0 || datos.num2 > 1000000000000)
            {
                return View("Error");
            }

            Operaciones operaciones = new Operaciones();
            Double result = operaciones.resta(datos);

            ViewBag.num1 = datos.num1;
            ViewBag.num2 = datos.num2;

            ViewBag.ResultSubtraction = result;

            return View();
        }

        public IActionResult Division(Datos datos)
        {

            if (datos.num1 < 0 || datos.num2 > 1000000000000)
            {
                return View("Error");
            }

            Operaciones operaciones = new Operaciones();
            Double result = operaciones.division(datos);

            ViewBag.num1 = datos.num1;
            ViewBag.num2 = datos.num2;

            ViewBag.ResultDivision = result;

            return View();
        }

        public IActionResult Multiplicacion(Datos datos)
        {

            if (datos.num1 < 0 || datos.num2 > 1000000000000)
            {
                return View("Error");
            }

            Operaciones operaciones = new Operaciones();
            Double result = operaciones.multiplicacion(datos);

            ViewBag.num1 = datos.num1;
            ViewBag.num2 = datos.num2;

            ViewBag.ResultMultiplication = result;

            return View();
        }
    }
}
