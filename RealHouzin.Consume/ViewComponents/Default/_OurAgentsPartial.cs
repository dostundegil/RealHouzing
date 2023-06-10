using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzin.Consume.Models;
using System.Net.Http;

namespace RealHouzin.Consume.ViewComponents.Default
{
    public class _OurAgentsPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _OurAgentsPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44379/api/Agent");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<AgentListViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
