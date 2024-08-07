using BankWebAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BankWebAPI.Controller
{
    [Route("api/BankController")]
    [ApiController]
    public class BankController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<BankDTO> GetBanks()
        {
            return new List<BankDTO>
            {
                new() {id=1,bankname="SBI"},
                new() {id=2,bankname="UBI"}
            };
        }
    }
}