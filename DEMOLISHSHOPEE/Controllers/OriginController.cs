using DEMOLISHSHOPEE.Models;
using DEMOLISHSHOPEE.Service;
using Microsoft.AspNetCore.Mvc;

namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OriginController : ControllerBase
    {
        private readonly QUANLYTHUONGMAIContext context;

        public OriginController(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            OriginService origin = new OriginService(context);
            return Ok(origin.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            OriginService origin = new OriginService(context);
            return Ok(origin.GetList());
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbOrigin TbOrigin)
        {
            OriginService origin = new OriginService(context);
            origin.Update(TbOrigin);
            return Ok("OK");
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] TbOrigin TbOrigin)
        {
            OriginService origin = new OriginService(context);
            origin.Add(TbOrigin);
            return Ok(TbOrigin);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            OriginService origin = new OriginService(context);
            origin.Delete(id);
            return Ok("Ok");
        }
    }
}