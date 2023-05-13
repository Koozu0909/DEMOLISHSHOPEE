using DEMOLISHSHOPEE.Models;
using DEMOLISHSHOPEE.Service;
using Microsoft.AspNetCore.Mvc;

namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteController : ControllerBase
    {
        private readonly QUANLYTHUONGMAIContext context;

        public FavoriteController(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            FavoriteService sv = new FavoriteService(context);
            return Ok(sv.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            FavoriteService sv = new FavoriteService(context);

            return Ok(sv.GetList());
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbFavourite tbFavourite)
        {
            FavoriteService sv = new FavoriteService(context);

            sv.Update(tbFavourite);
            return Ok("OK");
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] TbFavourite tbFavourite)
        {
            FavoriteService sv = new FavoriteService(context);

            sv.Add(tbFavourite);
            return Ok("OK");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            FavoriteService sv = new FavoriteService(context);

            sv.Delete(id);
            return Ok("Ok");
        }
    }
}