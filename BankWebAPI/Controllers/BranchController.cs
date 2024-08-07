using BankWebAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BankWebAPI.Controllers
{
    [Route("api/BranchController")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<BranchDTO> GetBranches()
        {
            return new List<BranchDTO>
            {
                 new () {id=1,branchname="Kolkata",address="Esplanade",state="WB",micrcode="654987",ifsccode="SBIN0012345",bankid=1}, 
                 new () {id=2,branchname="Siliguri",address="Hillcart Road",state="WB",micrcode="987654",ifsccode="UBIN879654", bankid=2}
            };
        }
    }
}