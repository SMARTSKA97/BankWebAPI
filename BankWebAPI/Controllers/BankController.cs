using BankWebAPI.Data;
using BankWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankWebAPI.Controller
{
    [Route("api/BankController")]
    [ApiController]
    public class BankController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Bank>> GetBanks()
        {
            foreach (var bank in BankStore.BankList)
            {
                bank.Branches = BranchStore.BranchList.Where(b => b.BankId == bank.Id).ToList();
            }
            return Ok(BankStore.BankList);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Bank> GetBank(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }

            var Bank = BankStore.BankList.FirstOrDefault(u => u.Id == id);

            if(Bank == null)
            {
                return NotFound();
            }

            return Ok(Bank);
        }
    }
}