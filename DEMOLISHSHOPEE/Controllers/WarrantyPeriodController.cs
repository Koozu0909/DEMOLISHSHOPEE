using DEMOLISHSHOPEE.Models;
using DEMOLISHSHOPEE.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarrantyPeriodController : ControllerBase
    {
        private readonly QUANLYTHUONGMAIContext context;

        public WarrantyPeriodController(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            WarrantyPeriodService WarrantyPeriod = new WarrantyPeriodService(context);
            return Ok(WarrantyPeriod.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            WarrantyPeriodService WarrantyPeriod = new WarrantyPeriodService(context);
            return Ok(WarrantyPeriod.GetList());
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbWarrantyPeriod TbWarrantyPeriod)
        {
            WarrantyPeriodService WarrantyPeriod = new WarrantyPeriodService(context);
            WarrantyPeriod.Update(TbWarrantyPeriod);
            return Ok("OK");
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] TbWarrantyPeriod TbWarrantyPeriod)
        {
            WarrantyPeriodService WarrantyPeriod = new WarrantyPeriodService(context);
            WarrantyPeriod.Add(TbWarrantyPeriod);
            return Ok(TbWarrantyPeriod);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            WarrantyPeriodService WarrantyPeriod = new WarrantyPeriodService(context);
            WarrantyPeriod.Delete(id);
            return Ok("Ok");
        }
    }
}
