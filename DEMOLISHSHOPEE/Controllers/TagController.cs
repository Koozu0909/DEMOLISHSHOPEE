using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DEMOLISHSHOPEE.Service;
using DEMOLISHSHOPEE.Models;


namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {

        private readonly QUANLYTHUONGMAIContext context;
        private readonly String connectionString = "Data Source=.;Initial Catalog=QUANLYTHUONGMAI;Integrated Security=True;TrustServerCertificate=True";

        public TagController(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }
        

        [HttpGet("{id}")]
        public IActionResult Get(int id) {
            TagService tag = new TagService(context);
            return Ok(tag.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            TagService tag = new TagService(context);
            return Ok(tag.GetList());
        }
        [HttpPost("")]
        public IActionResult Post([FromBody] TbTag TbTag)
        {
            TagService tag = new TagService(context);
            tag.Add(TbTag);
            return Ok("OK");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete (int id)
        {
            TagService tag = new TagService(context);
            tag.Delete(id);
            return Ok("Ok");
        }



    }
}
