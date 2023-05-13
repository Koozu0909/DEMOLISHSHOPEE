using DEMOLISHSHOPEE.Models;
using DEMOLISHSHOPEE.Service;
using Microsoft.AspNetCore.Mvc;

namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly QUANLYTHUONGMAIContext context;

        public UserController(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            UserService sv = new UserService(context);
            return Ok(sv.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            UserService sv = new UserService(context);

            return Ok(sv.GetList());
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbUser tbUser)
        {
            UserService sv = new UserService(context);

            sv.Update(tbUser);
            return Ok("OK");
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] TbUser tbUser)
        {
            UserService sv = new UserService(context);

            sv.Add(tbUser);
            return Ok("OK"); 
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            UserService sv = new UserService(context);

            sv.Delete(id);
            return Ok("Ok");
        }
    }
}