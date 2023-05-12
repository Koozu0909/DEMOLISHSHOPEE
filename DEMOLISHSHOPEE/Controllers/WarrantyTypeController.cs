using DEMOLISHSHOPEE.Models;
using DEMOLISHSHOPEE.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarrantyTypeController : ControllerBase
    {
        private readonly QUANLYTHUONGMAIContext context;

        public WarrantyTypeController(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            WarrantyTypeService WarrantyType = new WarrantyTypeService(context);
            return Ok(WarrantyType.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            WarrantyTypeService WarrantyType = new WarrantyTypeService(context);
            return Ok(WarrantyType.GetList());
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbWarrantyType TbWarrantyType)
        {
            WarrantyTypeService WarrantyType = new WarrantyTypeService(context);
            WarrantyType.Update(TbWarrantyType);
            return Ok("OK");
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] TbWarrantyType TbWarrantyType)
        {
            WarrantyTypeService WarrantyType = new WarrantyTypeService(context);
            WarrantyType.Add(TbWarrantyType);
            return Ok(TbWarrantyType);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            WarrantyTypeService WarrantyType = new WarrantyTypeService(context);
            WarrantyType.Delete(id);
            return Ok("Ok");
        }
    }
}
