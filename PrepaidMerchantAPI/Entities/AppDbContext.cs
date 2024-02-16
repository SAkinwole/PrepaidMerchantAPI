using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace PrepaidMerchantAPI.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
