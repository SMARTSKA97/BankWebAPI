public class Bank
{
    public int id { get; set; }
    public string bank_name { get; set; }
    public ICollection<Branch> Branches { get; set; }
}  
