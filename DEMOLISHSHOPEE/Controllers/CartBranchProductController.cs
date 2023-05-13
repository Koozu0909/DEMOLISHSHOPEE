using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DEMOLISHSHOPEE.Service;
using DEMOLISHSHOPEE.Models;


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
        public IActionResult Get(int id) {
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

        [HttpDelete("{id}")]
        public IActionResult Delete (int id)
        {
            CartBranchProductService sv = new CartBranchProductService(context);

            sv.Delete(id);
            return Ok("Ok");
        }



    }
}
