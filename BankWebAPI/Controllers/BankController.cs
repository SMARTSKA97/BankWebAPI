[ApiController]
[Route("api/[controller]")]
public class BanksController : ControllerBase
{
    private readonly BankingContext _context;

    public BanksController(BankingContext context)
    {
        _context = context;
    }

    [HttpGet]
    
    public async Task<ActionResult<IEnumerable<Bank>>> GetBanks()
    {
        return await _context.Banks.Include(b => b.Branches).ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Bank>> GetBank(int id)
    {
        var bank = await _context.Banks.Include(b => b.Branches)
                                        .FirstOrDefaultAsync(b => b.Id == id);
        if (bank == null)
        {
            return NotFound();
        }

        return bank;
    }

    [HttpPost]
    public async Task<ActionResult<Bank>> PostBank(Bank bank)
    {
        _context.Banks.Add(bank);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetBank), new { id = bank.Id }, bank);
    }

    // Implement other CRUD actions (PUT, DELETE)
}
