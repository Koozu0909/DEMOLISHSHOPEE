using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DEMOLISHSHOPEE.Service;
using DEMOLISHSHOPEE.Models;


namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressLV3Controller : ControllerBase
    {

        private readonly QUANLYTHUONGMAIContext context;
      
        public AddressLV3Controller(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }
        

        [HttpGet("{id}")]
        public IActionResult Get(int id) {
            AddressLV3Service tag = new AddressLV3Service(context);
            return Ok(tag.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            AddressLV3Service tag = new AddressLV3Service(context);
            return Ok(tag.GetList());
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbAddressLv3 addressLv3)
        {
            AddressLV3Service tag = new AddressLV3Service(context);
            tag.Update(addressLv3);
            return Ok("OK");
        }


        [HttpPost("")]
        public IActionResult Post([FromBody] TbAddressLv3 addressLv3)
        {
            AddressLV3Service tag = new AddressLV3Service(context);
            tag.Add(addressLv3);
            return Ok("OK");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete (int id)
        {
            AddressLV3Service addressLv3 = new AddressLV3Service(context);
            addressLv3.Delete(id);
            return Ok("Ok");
        }



    }
}
