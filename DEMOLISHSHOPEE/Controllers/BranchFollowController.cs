using DEMOLISHSHOPEE.Models;
using DEMOLISHSHOPEE.Service;
using Microsoft.AspNetCore.Mvc;

namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchFollowController : ControllerBase
    {
        private readonly QUANLYTHUONGMAIContext context;

        public BranchFollowController(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            BranchFollowService sv = new BranchFollowService(context);
            return Ok(sv.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            BranchFollowService sv = new BranchFollowService(context);
            return Ok(sv.GetList());
        }

        ///HttpPut
        [HttpPut("")]
        public IActionResult Update([FromBody] TbBranchFollow tbBranchFollow)
        {
            BranchFollowService sv = new BranchFollowService(context);
            sv.Update(tbBranchFollow);
            return Ok("OK");
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] TbBranchFollow tbBranchFollow)
        {
            BranchFollowService sv = new BranchFollowService(context);
            sv.Add(tbBranchFollow);
            return Ok("OK");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            BranchFollowService sv = new BranchFollowService(context);
            sv.Delete(id);
            return Ok("Ok");
        }
    }
}