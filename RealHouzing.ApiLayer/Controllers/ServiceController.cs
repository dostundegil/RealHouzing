using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.AgentDtos;
using RealHouzing.DtoLayer.FeatuesDtos;
using RealHouzing.DtoLayer.ServiceDtos;
using RealHouzing.EntityLayer.Concrate;

namespace RealHouzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _serviceService.TGetList();
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateService(UpdateServiceDto dto)
        {
            Service service = new Service()
            {
                ServiceID = dto.ServiceID,
                ServiceTitle = dto.ServiceTitle,
                ServiceDescription = dto.ServiceDescription,
                ServiceImage = dto.ServiceImage
            };
            _serviceService.TUpdate(service);
            return Ok();

        }

        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var values = _serviceService.TGetByID(id);
            return Ok(values);

        }

        [HttpPost]
        public IActionResult AddService(ResultServiceDto dto)
        {
            Service service = new Service()
            {
                ServiceTitle = dto.ServiceTitle,
                ServiceDescription = dto.ServiceDescription,
                ServiceImage = dto.ServiceImage

            };
            _serviceService.TInsert(service);
            return Ok();

        }
    }
}
