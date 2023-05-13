using DEMOLISHSHOPEE.Models;
using DEMOLISHSHOPEE.Service;
using Microsoft.AspNetCore.Mvc;

namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly QUANLYTHUONGMAIContext context;

        public CategoriesController(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            CategoriesService sv = new CategoriesService(context);
            return Ok(sv.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            CategoriesService sv = new CategoriesService(context);

            return Ok(sv.GetList());
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbCategory tbCategory)
        {
            CategoriesService sv = new CategoriesService(context);

            sv.Update(tbCategory);
            return Ok("OK");
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] TbCategory tbCategory)
        {
            CategoriesService sv = new CategoriesService(context);
            sv.Add(tbCategory);
            return Ok("OK");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            CategoriesService sv = new CategoriesService(context);

            sv.Delete(id);
            return Ok("Ok");
        }
    }
}