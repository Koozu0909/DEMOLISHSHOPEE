using DEMOLISHSHOPEE.Models;
using DEMOLISHSHOPEE.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly QUANLYTHUONGMAIContext context;

        public ProductController(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            ProductService sv = new ProductService(context);
            return Ok(sv.GetItem(id));
        }


        [HttpGet("")]
        public IActionResult Get()
        {
            ProductService sv = new ProductService(context);
            return Ok(sv.GetList());
        }

        ///HttpPost
        [HttpPost("")]
        public IActionResult Post([FromBody] TbProduct TbProduct)
        {
            ProductService sv = new ProductService(context);
            sv.Add(TbProduct);
            return Ok(TbProduct);
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbProduct TbProduct)
        {
            ProductService sv = new ProductService(context);
            sv.Update(TbProduct);
            return Ok(TbProduct);
        }

        ///HttpDelete
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            ProductService sv = new ProductService(context);
            sv.Delete(id);
            return Ok("Ok");
        }
    }
}
