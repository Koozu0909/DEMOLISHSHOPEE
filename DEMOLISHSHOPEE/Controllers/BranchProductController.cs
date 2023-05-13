using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DEMOLISHSHOPEE.Service;
using DEMOLISHSHOPEE.Models;


namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchProductController : ControllerBase
    {

        private readonly QUANLYTHUONGMAIContext context;
      
        public BranchProductController(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }
        

        [HttpGet("{id}")]
        public IActionResult Get(int id) {
            BranchProductService sv = new BranchProductService(context);
            return Ok(sv.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            BranchProductService sv = new BranchProductService(context);
            return Ok(sv.GetList());
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbBranchProduct tbBranchProduct)
        {
            BranchProductService sv = new BranchProductService(context);
            sv.Update(tbBranchProduct);
            return Ok("OK");
        }


        [HttpPost("")]
        public IActionResult Post([FromBody] TbBranchProduct tbBranchProduct)
        {
            BranchProductService sv = new BranchProductService(context);
            sv.Add(tbBranchProduct);
            return Ok("OK");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete (int id)
        {
            BranchProductService sv = new BranchProductService(context);

            sv.Delete(id);
            return Ok("Ok");
        }



    }
}
