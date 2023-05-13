using DEMOLISHSHOPEE.Models;
using DEMOLISHSHOPEE.Service;
using Microsoft.AspNetCore.Mvc;

namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly QUANLYTHUONGMAIContext context;

        public CommentController(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            CommentService sv = new CommentService(context);
            return Ok(sv.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            CommentService sv = new CommentService(context);

            return Ok(sv.GetList());
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbComment tbComment)
        {
            CommentService sv = new CommentService(context);

            sv.Update(tbComment);
            return Ok("OK");
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] TbComment tbComment)
        {
            CommentService sv = new CommentService(context);

            sv.Add(tbComment);
            return Ok("OK");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            CommentService sv = new CommentService(context);

            sv.Delete(id);
            return Ok("Ok");
        }
    }
}