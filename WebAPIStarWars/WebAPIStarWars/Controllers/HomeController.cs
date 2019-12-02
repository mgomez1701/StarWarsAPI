using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAPIStarWars.Models;

namespace WebAPIStarWars.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            DropDownSearch dropDownSearch = new DropDownSearch();
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co/api/");
            var response = await client.GetAsync($"people/");
            var person = await response.Content.ReadAsAsync<PersonListRoot>();
            dropDownSearch.Person = person;

            response = await client.GetAsync($"planets/");
            var planet = await response.Content.ReadAsAsync<PlanetListRoot>();
            dropDownSearch.Planet = planet;

            return View(dropDownSearch);
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
