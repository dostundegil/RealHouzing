using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzin.Consume.Models;
using System.Net.Http;

namespace RealHouzin.Consume.Controllers
{
    public class DefaultPropertiesController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultPropertiesController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44379/api/Product");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ProductListViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
