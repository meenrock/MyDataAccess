using Microsoft.EntityFrameworkCore;

namespace MyDataAccess.Context;

public static class TestData
{
    public static void RegisterTestData(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Income>().HasData(new[]
        {
            new Income
            {
                IncomeName = "Test Income Data",
                IncomeCategoryID = 1,
                IncomeAmount = 1000,
                UserID = 1111,
                IncomeDescription = "Hello this is the test",
                BookID = "2222",
                Status = "Active",
                IsVerified = "Verified",
                CreatedAt = new DateTime().Date,
                UpdatedAt = new DateTime().Date
            }
        });
    }
}