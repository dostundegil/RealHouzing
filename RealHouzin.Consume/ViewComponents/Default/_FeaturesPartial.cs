using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzin.Consume.Models;
using System.Net.Http;

namespace RealHouzin.Consume.ViewComponents.Default
{
    public class _FeaturesPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _FeaturesPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44379/api/Featues");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<FeatuesListViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
