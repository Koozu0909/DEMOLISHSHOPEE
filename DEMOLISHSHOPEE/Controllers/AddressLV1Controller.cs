using DEMOLISHSHOPEE.Models;
using DEMOLISHSHOPEE.Service;
using Microsoft.AspNetCore.Mvc;

namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressLV1Controller : ControllerBase
    {
        private readonly QUANLYTHUONGMAIContext context;

        public AddressLV1Controller(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            AddressLV1Service tag = new AddressLV1Service(context);
            return Ok(tag.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            AddressLV1Service tag = new AddressLV1Service(context);
            return Ok(tag.GetList());
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbAddressLv1 addressLv1)
        {
            AddressLV1Service tag = new AddressLV1Service(context);
            tag.Update(addressLv1);
            return Ok("OK");
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] TbAddressLv1 addressLv1)
        {
            AddressLV1Service tag = new AddressLV1Service(context);
            tag.Add(addressLv1);
            return Ok("OK");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            AddressLV1Service addresslv1 = new AddressLV1Service(context);
            addresslv1.Delete(id);
            return Ok("Ok");
        }
    }
}