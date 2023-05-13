using DEMOLISHSHOPEE.Models;
using DEMOLISHSHOPEE.Service;
using Microsoft.AspNetCore.Mvc;

namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly QUANLYTHUONGMAIContext context;

        public OrderDetailController(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            OrderDetailService sv = new OrderDetailService(context);
            return Ok(sv.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            OrderDetailService sv = new OrderDetailService(context);

            return Ok(sv.GetList());
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbOrderDetail tbOrderDetail)
        {
            OrderDetailService sv = new OrderDetailService(context);
            sv.Update(tbOrderDetail);
            return Ok("OK");
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] TbOrderDetail tbOrderDetail)
        {
            OrderDetailService sv = new OrderDetailService(context);

            sv.Add(tbOrderDetail);
            return Ok("OK");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            OrderDetailService sv = new OrderDetailService(context);

            sv.Delete(id);
            return Ok("Ok");
        }
    }
}