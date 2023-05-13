using DEMOLISHSHOPEE.Models;
using DEMOLISHSHOPEE.Service;
using Microsoft.AspNetCore.Mvc;

namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageSlideController : ControllerBase
    {
        private readonly QUANLYTHUONGMAIContext context;

        public ImageSlideController(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            ImageSlideService sv = new ImageSlideService(context);
            return Ok(sv.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            ImageSlideService sv = new ImageSlideService(context);

            return Ok(sv.GetList());
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbImageSlide tbImageSlide)
        {
            ImageSlideService sv = new ImageSlideService(context);

            sv.Update(tbImageSlide);
            return Ok("OK");
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] TbImageSlide tbImageSlide)
        {
            ImageSlideService sv = new ImageSlideService(context);

            sv.Add(tbImageSlide);
            return Ok("OK");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            ImageSlideService sv = new ImageSlideService(context);

            sv.Delete(id);
            return Ok("Ok");
        }
    }
}