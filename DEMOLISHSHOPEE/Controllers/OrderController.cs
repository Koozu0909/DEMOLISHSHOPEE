using DEMOLISHSHOPEE.Models;
using DEMOLISHSHOPEE.Service;
using Microsoft.AspNetCore.Mvc;

namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly QUANLYTHUONGMAIContext context;

        public OrderController(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            OrderService sv = new OrderService(context);
            return Ok(sv.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            OrderService sv = new OrderService(context);

            return Ok(sv.GetList());
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbOrder tbOrder)
        {
            OrderService sv = new OrderService(context);

            sv.Update(tbOrder);
            return Ok("OK");
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] TbOrder tbOrder)
        {
            OrderService sv = new OrderService(context);

            sv.Add(tbOrder);
            return Ok("OK");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            OrderService sv = new OrderService(context);

            sv.Delete(id);
            return Ok("Ok");
        }
    }
}