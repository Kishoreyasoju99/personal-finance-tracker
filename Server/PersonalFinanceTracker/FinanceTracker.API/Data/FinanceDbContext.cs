using FinanceTracker.API.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceTracker.API.Data
{
    public class FinanceDbContext : DbContext
    {

            public FinanceDbContext(DbContextOptions<FinanceDbContext> options)
                : base(options)
            {
            }

            public DbSet<User> Users { get; set; } = null!;
            public DbSet<Category> Categories { get; set; } = null!;
            public DbSet<Transaction> Transactions { get; set; } = null!;
        

    }
}
