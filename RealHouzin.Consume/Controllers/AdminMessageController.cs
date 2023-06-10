using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzin.Consume.Models;
using System.Text;

namespace RealHouzin.Consume.Controllers
{
    public class AdminMessageController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminMessageController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44379/api/Message/GetRecievedMessages");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<MessageViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> DeleteMessage(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:44379/api/Message/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> MessageDetails(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:44379/api/Message/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<MessageViewModel>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Reply(int id)
        {
            mailRequestViewModel model = new mailRequestViewModel();
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:44379/api/Message/{id}");

            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<MessageViewModel>(jsonData);
            ViewBag.mail = values.Mail;
            ViewBag.name = values.Name;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Reply(mailRequestViewModel model)
        {
            MessageViewModel messageModel = new MessageViewModel()
            {
                Mail = model.ReceiverMail,
                MessageContent = model.Body.ToString(),
                Type = "Gönderilen Mesajlar",
                Date = DateTime.Now,
                Name = model.Name
            };
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(messageModel);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:44379/api/Message", stringContent);
            MailRequest mailRequest = new MailRequest();
            mailRequest.SendMail(model);
            return RedirectToAction("Index");
        }

    }
}
