using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPIStarWars.Models;

namespace WebAPIStarWars.Controllers
{
    public class PlanetsController : Controller
    {
        public async Task<IActionResult> GetPlanetsbyId(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co/api/");
            var response = await client.GetAsync($"planets/{id}");
            var person = await response.Content.ReadAsAsync<Planet>();

            return View(person);
        }
    }
}