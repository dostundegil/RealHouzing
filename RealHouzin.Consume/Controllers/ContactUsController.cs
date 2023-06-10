using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzin.Consume.Models;
using RealHouzin.Consume.ViewComponents;
using System.Net.Http;
using System.Text;

namespace RealHouzin.Consume.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactUsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44379/api/ContactUs");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ContactUsViewModel>>(jsonData);
                ViewBag.address = values[0].Address;
                ViewBag.telephone1 = values[0].Telephone1;
                ViewBag.telephone2 = values[0].Telephone2;
                ViewBag.mail = values[0].Mail;
                ViewBag.website = values[0].Website;
                return PartialView();
            }

            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> Index(MessageViewModel model)
        {
            model.Date = DateTime.Now;
            model.Type = "Gelen Mesajlar";
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:44379/api/Message", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return PartialView();
            }
            return PartialView();
        }
        public async Task<IActionResult> ContactUsAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44379/api/ContactUs");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ContactUsViewModel>>(jsonData);
                ViewBag.address = values[0].Address;
                ViewBag.telephone1 = values[0].Telephone1;
                ViewBag.telephone2 = values[0].Telephone2;
                ViewBag.mail = values[0].Mail;
                ViewBag.website = values[0].Website;
                return PartialView();
            }
            
            return PartialView();
        }
    }
}
