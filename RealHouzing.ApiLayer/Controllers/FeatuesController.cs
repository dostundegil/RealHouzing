using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.ContactUsDtos;
using RealHouzing.DtoLayer.FeatuesDtos;
using RealHouzing.EntityLayer.Concrate;

namespace RealHouzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatuesController : ControllerBase
    {
        private readonly IFeatuesService _featuesService;

        public FeatuesController(IFeatuesService featuesService)
        {
            _featuesService = featuesService;
        }

        [HttpGet]
        public IActionResult FeatuesList()
        {
            var values = _featuesService.TGetList();
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateFeatues(UpdateFeatuesDto dto)
        {
            Featues featues = new Featues()
            {
                FeatuesID = dto.FeatuesID,
                FeatuesTitle = dto.FeatuesTitle,
                FeatuesContent = dto.FeatuesContent,
                FeatuesImage = dto.FeatuesImage,
            };
            _featuesService.TUpdate(featues);
            return Ok();

        }

        [HttpGet("{id}")]
        public IActionResult GetFeatues(int id)
        {
            var values = _featuesService.TGetByID(id);
            return Ok(values);

        }
    }
}
