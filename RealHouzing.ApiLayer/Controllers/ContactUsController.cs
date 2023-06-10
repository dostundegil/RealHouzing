using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.AboutUsDtos;
using RealHouzing.DtoLayer.CategoryDtos;
using RealHouzing.DtoLayer.ContactUsDtos;
using RealHouzing.EntityLayer.Concrate;

namespace RealHouzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsController : ControllerBase
    {
        private readonly IContactUsService _contactUsService;

        public ContactUsController(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }

        [HttpGet]
        public IActionResult ContactUsList()
        {
            var values = _contactUsService.TGetList();
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateContactUs(UpdateContactUsDto dto)
        {
            ContactUs contactUs = new ContactUs()
            {
                ContactUsID = dto.ContactUsID,
                Address = dto.Address,
                Telephone1 = dto.Telephone1,
                Telephone2 = dto.Telephone2,
                Website = dto.Website,
                Mail = dto.Mail,
                MapUrl = dto.MapUrl
            };
            _contactUsService.TUpdate(contactUs);
            return Ok();

        }

        [HttpGet("{id}")]
        public IActionResult GetContactUs(int id)
        {
            var values = _contactUsService.TGetByID(id);
            return Ok(values);

        }
    }
}
