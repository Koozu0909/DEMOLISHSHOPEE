using DEMOLISHSHOPEE.Models;
using DEMOLISHSHOPEE.Service;
using Microsoft.AspNetCore.Mvc;

namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly QUANLYTHUONGMAIContext context;

        public AddressController(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            AddressService tag = new AddressService(context);
            return Ok(tag.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            AddressService tag = new AddressService(context);
            return Ok(tag.GetList());
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbAddress address)
        {
            AddressService tag = new AddressService(context);
            tag.Update(address);
            return Ok("OK");
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] TbAddress address)
        {
            AddressService tag = new AddressService(context);
            tag.Add(address);
            return Ok("OK");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            AddressService addressLv3 = new AddressService(context);
            addressLv3.Delete(id);
            return Ok("Ok");
        }
    }
}