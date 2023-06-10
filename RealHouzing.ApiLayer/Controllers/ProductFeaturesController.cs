using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.EntityLayer.Concrate;

namespace RealHouzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductFeaturesController : ControllerBase
    {
        private readonly IProductPropertyFeaturesService _productPropertyFeaturesService;

        public ProductFeaturesController(IProductPropertyFeaturesService productPropertyFeaturesService)
        {
            _productPropertyFeaturesService = productPropertyFeaturesService;
        }

        [HttpGet]
        public IActionResult ProductFeaturesList(int id)
        {
            var values = _productPropertyFeaturesService.TGetFeaturesByProduct(id);
            return Ok(values);
        }
    }
}
