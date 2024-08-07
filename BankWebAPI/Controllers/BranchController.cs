using BankWebAPI.Data;
using BankWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankWebAPI.Controllers
{
    [Route("api/BranchController")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Branch>>> GetBranches()
        {
            return BranchStore.BranchList;
        }

        [HttpGet("{id:int}")]
        public ActionResult<Branch> GetBranch(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var branch = BranchStore.BranchList.FirstOrDefault(u => u.Id == id);


            if (branch == null)
            {
                return NotFound();
            }
            return Ok(branch);
        }
    }
}
