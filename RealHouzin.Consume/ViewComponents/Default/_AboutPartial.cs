using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzin.Consume.Models;

namespace RealHouzin.Consume.ViewComponents.Default
{
    public class _AboutPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AboutPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44379/api/AboutUs");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<AboutUsViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
