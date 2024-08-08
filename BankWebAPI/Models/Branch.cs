using System.ComponentModel.DataAnnotations;

namespace BankWebAPI.Models
{
    public class Branch
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string? BranchName { get; set; }
        [Required]
        [MaxLength(255)]
        public string? Address { get; set; }
        [Required]
        [MaxLength(255)]
        public string? State { get; set; }
        [Required]
        [MaxLength(50)]
        public string? MICRCode { get; set; }
        [Required]
        [MaxLength(50)]
        public string? IFSCCode { get; set; }
        [Required]
        //[ForeignKey("Bank")]
        public int BankId { get; set; }
       
    }
}