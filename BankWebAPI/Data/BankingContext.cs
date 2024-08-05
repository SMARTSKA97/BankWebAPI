public class BankingContext : DbContext
{
    public DbSet<Bank> Banks { get; set; }
    public DbSet<Branch> Branches { get; set; }

    public BankingContext(DbContextOptions<BankingContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bank>()
            .HasMany(b => b.Branches)
            .WithOne(br => br.Bank)
            .HasForeignKey(br => br.BankId);

        base.OnModelCreating(modelBuilder);
    }
}
