using DEMOLISHSHOPEE.Models;
using DEMOLISHSHOPEE.Service;
using Microsoft.AspNetCore.Mvc;

namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly QUANLYTHUONGMAIContext context;

        public CartController(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            CartService sv = new CartService(context);
            return Ok(sv.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            CartService sv = new CartService(context);

            return Ok(sv.GetList());
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbCart tbCart)
        {
            CartService sv = new CartService(context);

            sv.Update(tbCart);
            return Ok("OK");
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] TbCart tbCart)
        {
            CartService sv = new CartService(context);
            sv.Add(tbCart);
            return Ok("OK");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            CartService sv = new CartService(context);

            sv.Delete(id);
            return Ok("Ok");
        }
    }
}