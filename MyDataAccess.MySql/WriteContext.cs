using Microsoft.EntityFrameworkCore;
using MyDataAccess.Context;

namespace MyDataAccess.MySql
{
    public class WriteContext : BalanceSheetWriteContext
    {
        public WriteContext(DbContextOptions options) : base(options)
        {
            
        }

        protected void OnModelCreation(ModelBuilder modelBuilder)
        {
            
        }
    }
}

