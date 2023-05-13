using DEMOLISHSHOPEE.Models;
using DEMOLISHSHOPEE.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleCateController : ControllerBase
    {
        private readonly QUANLYTHUONGMAIContext context;
       
        public RoleCateController(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            RoleCateService sv = new RoleCateService(context);
            return Ok(sv.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            RoleCateService sv = new RoleCateService(context);

            return Ok(sv.GetList());
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbRoleCate tbRoleCate)
        {
            RoleCateService sv = new RoleCateService(context);

            sv.Update(tbRoleCate);
            return Ok("OK");
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] TbRoleCate tbRoleCate)
        {
            RoleCateService sv = new RoleCateService(context);

            sv.Add(tbRoleCate);
            return Ok("OK");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            RoleCateService sv = new RoleCateService(context);

            sv.Delete(id);
            return Ok("Ok");
        }
    }
}
