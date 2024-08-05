public class Branch
{
    public int id { get; set; }
    public string branch_name { get; set; }
    public string address { get; set; }
    public string state { get; set; }
    public string MICR_code { get; set; }
    public string IFSC_code { get; set; }
    public int bank_id { get; set; }
    public Bank Bank { get; set; }
}
