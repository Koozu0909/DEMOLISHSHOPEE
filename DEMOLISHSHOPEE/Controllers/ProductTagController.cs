using DEMOLISHSHOPEE.Models;
using DEMOLISHSHOPEE.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTagController : ControllerBase
    {
        private readonly QUANLYTHUONGMAIContext context;
       
        public ProductTagController(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            ProductTagService sv = new ProductTagService(context);
            return Ok(sv.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            ProductTagService sv = new ProductTagService(context);

            return Ok(sv.GetList());
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbProductTag tbProductTag)
        {
            ProductTagService sv = new ProductTagService(context);

            sv.Update(tbProductTag);
            return Ok("OK");
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] TbProductTag tbProductTag)
        {
            ProductTagService sv = new ProductTagService(context);

            sv.Add(tbProductTag);
            return Ok("OK");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            ProductTagService sv = new ProductTagService(context);

            sv.Delete(id);
            return Ok("Ok");
        }
    }
}
