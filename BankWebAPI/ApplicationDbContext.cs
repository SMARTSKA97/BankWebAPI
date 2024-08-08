using BankWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BankWebAPI
{
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }
            
            public DbSet<Bank> Banks { get; set; }
            public DbSet<Branch> Branches { get; set; }
        }
}