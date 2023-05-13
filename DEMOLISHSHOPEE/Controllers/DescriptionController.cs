using DEMOLISHSHOPEE.Models;
using DEMOLISHSHOPEE.Service;
using Microsoft.AspNetCore.Mvc;

namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DescriptionController : ControllerBase
    {
        private readonly QUANLYTHUONGMAIContext context;

        public DescriptionController(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            DescriptionService sv = new DescriptionService(context);
            return Ok(sv.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            DescriptionService sv = new DescriptionService(context);

            return Ok(sv.GetList());
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbDescription tbDescription)
        {
            DescriptionService sv = new DescriptionService(context);

            sv.Update(tbDescription);
            return Ok("OK");
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] TbDescription tbDescription)
        {
            DescriptionService sv = new DescriptionService(context);

            sv.Add(tbDescription);
            return Ok("OK");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            DescriptionService sv = new DescriptionService(context);

            sv.Delete(id);
            return Ok("Ok");
        }
    }
}