using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DEMOLISHSHOPEE.Service;
using DEMOLISHSHOPEE.Models;


namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressLV2Controller : ControllerBase
    {

        private readonly QUANLYTHUONGMAIContext context;
      
        public AddressLV2Controller(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }
        

        [HttpGet("{id}")]
        public IActionResult Get(int id) {
            AddressLV2Service tag = new AddressLV2Service(context);
            return Ok(tag.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            AddressLV2Service tag = new AddressLV2Service(context);
            return Ok(tag.GetList());
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbAddressLv2 addressLv2)
        {
            AddressLV2Service tag = new AddressLV2Service(context);
            tag.Update(addressLv2);
            return Ok("OK");
        }


        [HttpPost("")]
        public IActionResult Post([FromBody] TbAddressLv2 addressLv2)
        {
            AddressLV2Service tag = new AddressLV2Service(context);
            tag.Add(addressLv2);
            return Ok("OK");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete (int id)
        {
            AddressLV2Service addressLv2 = new AddressLV2Service(context);
            addressLv2.Delete(id);
            return Ok("Ok");
        }



    }
}
