using Microsoft.EntityFrameworkCore;

namespace MyDataAccess.Context
{
    public static class ModelBuilderExtensions
    {
        public static void ConfigureRelations(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Income>(ctx =>
            {
                ctx.Property(ctx => ctx.IncomeName).IsRequired().HasMaxLength(128);
                ctx.Property(ctx => ctx.IncomeID).IsRequired();
                ctx.Property(ctx => ctx.IncomeCategoryID).IsRequired().HasMaxLength(128);
                ctx.Property(ctx => ctx.IncomeAmount).IsRequired();
                ctx.Property(ctx => ctx.IncomeDescription).HasMaxLength(128);
                ctx.Property(ctx => ctx.BookID).IsRequired();
                ctx.Property(ctx => ctx.Status).IsRequired().HasMaxLength(40);
                ctx.Property(ctx => ctx.IsVerified).IsRequired().HasMaxLength(40);
                ctx.HasIndex(ctx => new { ctx.IncomeID }).IsUnique();
            });
        }
    }
}

