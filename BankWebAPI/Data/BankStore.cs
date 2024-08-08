using BankWebAPI.Models;

namespace BankWebAPI.Data
{
    public static class BankStore
    {
        public static List<Bank> BankList { get; set; } = new List<Bank>
        {
            new Bank { Id = 1, BankName = "SBI" },
            new Bank { Id = 2, BankName = "UBI" }
        };
    }
}