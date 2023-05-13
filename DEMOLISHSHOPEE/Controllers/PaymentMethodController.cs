using DEMOLISHSHOPEE.Models;
using DEMOLISHSHOPEE.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentMethodController : ControllerBase
    {
        private readonly QUANLYTHUONGMAIContext context;
       
        public PaymentMethodController(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            PaymentMethodService sv = new PaymentMethodService(context);
            return Ok(sv.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            PaymentMethodService sv = new PaymentMethodService(context);
            return Ok(sv.GetList());
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbPaymentMethod tbPaymentMethod)
        {
            PaymentMethodService sv = new PaymentMethodService(context);
            sv.Update(tbPaymentMethod);
            return Ok("OK");
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] TbPaymentMethod tbPaymentMethod)
        {
            PaymentMethodService sv = new PaymentMethodService(context);
            sv.Add(tbPaymentMethod);
            return Ok("OK");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            PaymentMethodService sv = new PaymentMethodService(context);

            sv.Delete(id);
            return Ok("Ok");
        }
    }
}
