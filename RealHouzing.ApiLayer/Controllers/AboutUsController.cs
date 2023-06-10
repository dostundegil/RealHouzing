using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.AboutUsDtos;
using RealHouzing.DtoLayer.CategoryDtos;
using RealHouzing.EntityLayer.Concrate;

namespace RealHouzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : ControllerBase
    {
        private readonly IAboutUsService _aboutUsService;

        public AboutUsController(IAboutUsService aboutUsService)
        {
            _aboutUsService = aboutUsService;
        }

        [HttpGet]
        public IActionResult AboutUsList()
        {
            var values = _aboutUsService.TGetList();
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateAboutUs(UpdateAboutUsDto dto)
        {
            AboutUs aboutUs = new AboutUs()
            {
                AboutUsTitle = dto.AboutUsTitle,
                AboutUsID = dto.AboutUsID,
                AboutUsContent = dto.AboutUsContent,

            };
            _aboutUsService.TUpdate(aboutUs);
            return Ok();

        }
        [HttpGet("{id}")]
        public IActionResult GetAboutUs(int id)
        {
            var values = _aboutUsService.TGetByID(id);
            return Ok(values);

        }
    }
}
