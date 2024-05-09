using celilcavus.Market.Entity;
using celilcavus.Market.Model.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace celilcavus.Market.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategory _category;

        public CategoryController(ICategory category)
        {
            _category = category;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var values = _category.GetAll();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var values = _category.GetById(id);
            return Ok(values);
        }

        [HttpPost]
        public IActionResult Post(Category category)
        {
            _category.Add(category);
            _category.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var values = _category.GetById(id);
            _category.Delete(values);
            _category.SaveChanges();
            return Ok();
        }
    }
}
