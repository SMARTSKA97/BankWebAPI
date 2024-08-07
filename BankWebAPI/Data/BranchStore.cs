using BankWebAPI.Models;
using BankWebAPI.Controller;
using BankWebAPI.Data;
using Microsoft.VisualBasic;

namespace BankWebAPI.Data
{
    public static class BranchStore
    {
        public static List<Branch> BranchList = new List<Branch>
        {
                new () {Id=1,BranchName="Kolkata",Address="Esplanade",State="WB",MICRCode="654987",IFSCCode="SBIN0012345",BankId=1}, 
                new () {Id=2,BranchName="Siliguri",Address="Hillcart Road",State="WB",MICRCode="987654",IFSCCode="UBIN879654", BankId=2}
        };
    }
}