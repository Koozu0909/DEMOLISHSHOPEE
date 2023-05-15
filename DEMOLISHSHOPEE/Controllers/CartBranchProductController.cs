using DEMOLISHSHOPEE.Models;
using DEMOLISHSHOPEE.Service;
using Microsoft.AspNetCore.Mvc;

namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartBranchProductController : ControllerBase
    {
        private readonly QUANLYTHUONGMAIContext context;

        public CartBranchProductController(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            CartBranchProductService sv = new CartBranchProductService(context);
            return Ok(sv.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            CartBranchProductService sv = new CartBranchProductService(context);

            return Ok(sv.GetList());
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbCartBranchProduct tbCartBranchProduct)
        {
            CartBranchProductService sv = new CartBranchProductService(context);

            sv.Update(tbCartBranchProduct);
            return Ok("OK");
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] TbCartBranchProduct tbCartBranchProduct)
        {
            CartBranchProductService sv = new CartBranchProductService(context);
            sv.Add(tbCartBranchProduct);
            return Ok("OK");
        }

        [HttpDelete("{idCart}/{idBranchProduct}")]
        public IActionResult Delete(int idCart, int idBranchProduct)
        {
            CartBranchProductService sv = new CartBranchProductService(context);

            sv.Delete(idCart, idBranchProduct);
            return Ok("Ok");
        }
    }
}