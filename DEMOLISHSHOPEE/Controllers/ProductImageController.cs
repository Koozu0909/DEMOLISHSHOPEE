using DEMOLISHSHOPEE.Models;
using DEMOLISHSHOPEE.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImageController : ControllerBase
    {
        private readonly QUANLYTHUONGMAIContext context;
       
        public ProductImageController(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            ProductImageService sv = new ProductImageService(context);
            return Ok(sv.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            ProductImageService sv = new ProductImageService(context);
            return Ok(sv.GetList());
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbProductImage tbProductImage)
        {
            ProductImageService sv = new ProductImageService(context);
            sv.Update(tbProductImage);
            return Ok("OK");
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] TbProductImage tbProductImage)
        {
            ProductImageService sv = new ProductImageService(context);
            sv.Add(tbProductImage);
            return Ok("OK");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            ProductImageService sv = new ProductImageService(context);

            sv.Delete(id);
            return Ok("Ok");
        }
    }
}
