using Microsoft.EntityFrameworkCore;

namespace MyDataAccess.Context
{
    public class BalanceSheetWriteContext : DbContext
    {
        protected BalanceSheetWriteContext(DbContextOptions options) : base(options)
        {
        
        }
    
        public DbSet<Income> Incomes { get; set; }
    }
}

