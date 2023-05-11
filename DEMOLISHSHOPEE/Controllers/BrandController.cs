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
        private readonly String connectionString = "Data Source=.;Initial Catalog=QUANLYTHUONGMAI;Integrated Security=True;TrustServerCertificate=True";

        public BrandController(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            BrandService brand = new BrandService(context);
            return Ok(brand.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            BrandService brand = new BrandService(context);

            return Ok(brand.GetList());
        }
        [HttpPost("")]
        public IActionResult Post([FromBody] TbBrand TbBrand)
        {
            BrandService brand = new BrandService(context);

            brand.Add(TbBrand);
            return Ok("OK");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            BrandService brand = new BrandService(context);

            brand.Delete(id);
            return Ok("Ok");
        }

    }
}
