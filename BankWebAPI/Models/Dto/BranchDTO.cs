namespace BankWebAPI.Models.Dto
{
    public class BranchDTO
    {
        public int id { get; set; }
        public string branchname { get; set; }
        public string address { get; set; }
        public string state { get; set; }
        public string micrcode { get; set; }
        public string ifsccode { get; set; }
        public int bankid { get; set; }
    }
}