using celilcavus.Market.Entity;
using celilcavus.Market.Model;
using celilcavus.Market.Model.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace celilcavus.Market.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellerController : ControllerBase
    {
        private readonly ISeller _seller;

        public SellerController(ISeller seller)
        {
            _seller = seller;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var values = _seller.GetAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var values = _seller.GetById(id);
            return Ok(values);
        }

        [HttpPost]
        public IActionResult Post(Seller seller)
        {
            string name = _seller.ImageUpload(seller.Image, ConstLocation.Sellers);
            seller.ImageName = name;
            _seller.Add(seller);
            _seller.SaveChanges();
            return Ok();
        }
    }
}
