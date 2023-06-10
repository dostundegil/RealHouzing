using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.ServiceDtos;
using RealHouzing.DtoLayer.TestimonialDtos;
using RealHouzing.EntityLayer.Concrate;

namespace RealHouzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _testimonialService.TGetList();
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto dto)
        {
            Testimonial testimonial = new Testimonial()
            {
                TestimonialID = dto.TestimonialID,
                TestimonialName = dto.TestimonialName,
                TestimonialContent = dto.TestimonialContent,
            };
            _testimonialService.TUpdate(testimonial);
            return Ok();

        }

        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var values = _testimonialService.TGetByID(id);
            return Ok(values);

        }

        [HttpPost]
        public IActionResult AddTestimonial(ResultTestimonialDto dto)
        {
            Testimonial testimonial = new Testimonial()
            {
                TestimonialName = dto.TestimonialName,
                TestimonialContent = dto.TestimonialContent,

            };
            _testimonialService.TInsert(testimonial);
            return Ok();

        }
    }
}
