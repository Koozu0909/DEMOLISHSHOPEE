using DEMOLISHSHOPEE.Models;
using DEMOLISHSHOPEE.Service;
using Microsoft.AspNetCore.Mvc;

namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly QUANLYTHUONGMAIContext context;

        public TagController(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            TagService tag = new TagService(context);
            return Ok(tag.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            TagService tag = new TagService(context);
            return Ok(tag.GetList());
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbTag TbTag)
        {
            TagService tag = new TagService(context);
            tag.Update(TbTag);
            return Ok("OK");
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] TbTag TbTag)
        {
            TagService tag = new TagService(context);
            tag.Add(TbTag);
            return Ok(TbTag);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            TagService tag = new TagService(context);
            tag.Delete(id);
            return Ok("Ok");
        }
    }
}