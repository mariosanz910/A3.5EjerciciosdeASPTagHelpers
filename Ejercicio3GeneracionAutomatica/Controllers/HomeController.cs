using System.Collections.Generic;
using System.Diagnostics;
using Ejercicio3GeneracionAutomatica.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio3GeneracionAutomatica.Controllers
{
    public class HomeController : Controller
    {
        // Lista simulando la base de datos en memoria
        private static List<Movie> movies = new List<Movie>();
        private static int nextId = 1;

        public IActionResult Index()
        {
            // Pasar la lista completa de películas a la vista
            return View(movies);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                // Asignar ID automático y guardar en la lista
                movie.ID = nextId++;
                movies.Add(movie);

                // Redirigir a la lista principal
                return RedirectToAction("Index");
            }

            // Si hay errores, regresar al formulario
            return View(movie);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
