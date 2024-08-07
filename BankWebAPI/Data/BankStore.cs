using BankWebAPI.Models;
using System.Collections.Generic;

namespace BankWebAPI.Data
{
    public static class BankStore
    {
        public static List<Bank> BankList { get; set; } = new List<Bank>
        {
            new Bank { Id = 1, BankName = "SBI", Branches = new List<Branch>() },
            new Bank { Id = 2, BankName = "UBI", Branches = new List<Branch>() }
        };
    }
}