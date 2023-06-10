using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.ProductDtos;
using RealHouzing.EntityLayer.Concrate;

namespace RealHouzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult ProductList()
        {
            var values = _productService.TGetList();
            return Ok(values);
        }
        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory()
        {
            var values = _productService.TGetProductsWithCategories();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddProduct(AddProductDto addProductDto)
        {
            Product product = new Product()
            {
                BathCount = addProductDto.BathCount,
                BedroomCount = addProductDto.BedroomCount,
                CategoryID = addProductDto.CategoryID,
                CoverImageUrl = addProductDto.CoverImageUrl,
                Address = addProductDto.Address,
                ProductPrice = addProductDto.ProductPrice,
                ProductTitle = addProductDto.ProductTitle,
                ProductType = addProductDto.ProductType,
                Square = addProductDto.Square
            };
            _productService.TInsert(product);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var values = _productService.TGetByID(id);
            _productService.TDelete(values);
            return Ok();
        }
        [HttpGet("id")]
        public IActionResult GetProductByID(int id)
        {
            var value = _productService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult EditProduct(UpdateProductDto updateProductDto)
        {
            Product product = new Product()
            {
                ProductID = updateProductDto.ProductID,
                BathCount = updateProductDto.BathCount,
                BedroomCount = updateProductDto.BedroomCount,
                CategoryID = updateProductDto.CategoryID,
                CoverImageUrl = updateProductDto.CoverImageUrl,
                Address = updateProductDto.Address,
                ProductPrice = updateProductDto.ProductPrice,
                ProductTitle = updateProductDto.ProductTitle,
                ProductType = updateProductDto.ProductType,
                Square = updateProductDto.Square
            };
            _productService.TUpdate(product);
            return Ok();
        }
    }
}
