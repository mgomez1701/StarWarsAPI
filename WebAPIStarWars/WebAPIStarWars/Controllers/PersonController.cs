using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIStarWars.Controllers
{
    public class PersonController : Controller
    {
        private readonly HttpClient _client;

        public PersonController(IHttpClientFactory client)
        {
            _client = client.CreateClient();
            _client.BaseAddress = new Uri ("https://swapi.co/api/")
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}