using DEMOLISHSHOPEE.Models;
using DEMOLISHSHOPEE.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly QUANLYTHUONGMAIContext context;
      
        public BrandController(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        ///HttpGetid
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            BrandServicse brand = new BrandServicse(context);
            return Ok(brand.GetItem(id));
        }

        ///HttpGetList
        [HttpGet("")]
        public IActionResult Get()
        {
            BrandServicse brand = new BrandServicse(context);

            return Ok(brand.GetList());
        }

        ///HttpPost
        [HttpPost("")]
        public IActionResult Post([FromBody] TbBrand TbBrand)
        {
            BrandServicse brand = new BrandServicse(context);

            brand.Add(TbBrand);
            return Ok("OK");
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbBrand TbBrand)
        {
            BrandServicse brand = new BrandServicse(context);
            brand.Update(TbBrand);
            return Ok("OK");
        }

        ///HttpDelete
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            BrandServicse brand = new BrandServicse(context);

            brand.Delete(id);
            return Ok("Ok");
        }

    }
}
