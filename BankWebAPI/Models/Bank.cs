using System.ComponentModel.DataAnnotations;

namespace BankWebAPI.Models
{
    public class Bank
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string? BankName { get; set; }
        //public ICollection<Branch>? Branches { get; set; }
    }
}