using DEMOLISHSHOPEE.Models;
using DEMOLISHSHOPEE.Service;
using Microsoft.AspNetCore.Mvc;

namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusOrderController : ControllerBase
    {
        private readonly QUANLYTHUONGMAIContext context;

        public StatusOrderController(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            StatusOrderService sv = new StatusOrderService(context);
            return Ok(sv.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            StatusOrderService sv = new StatusOrderService(context);

            return Ok(sv.GetList());
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbStatusOrder tbStatusOrder)
        {
            StatusOrderService sv = new StatusOrderService(context);

            sv.Update(tbStatusOrder);
            return Ok("OK");
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] TbStatusOrder tbStatusOrder)
        {
            StatusOrderService sv = new StatusOrderService(context);

            sv.Add(tbStatusOrder);
            return Ok("OK");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            StatusOrderService sv = new StatusOrderService(context);

            sv.Delete(id);
            return Ok("Ok");
        }
    }
}