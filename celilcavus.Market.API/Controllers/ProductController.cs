using celilcavus.Market.Entity;
using celilcavus.Market.Model;
using celilcavus.Market.Model.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace celilcavus.Market.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _product;

        public ProductController(IProduct product)
        {
            _product = product;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var values = _product.GetAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var getByVal = _product.GetById(id);
            return Ok(getByVal);
        }

        [HttpPost]
        public IActionResult Post([FromForm]Product product)
        {
            string image = _product.ImageUpload(product.Image, ConstLocation.Products);
            product.ImageName = image;
            _product.Add(product);
            _product.SaveChanges();
            return Ok();    
        }
    }
}
