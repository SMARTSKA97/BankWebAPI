namespace BankWebAPI.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public string BranchName { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string MICRCode { get; set; }
        public string IFSCCode { get; set; }
        public int BankId { get; set; }
        public Bank Bank{ get; set; }
    }
}