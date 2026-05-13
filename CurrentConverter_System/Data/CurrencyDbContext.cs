using CurrentConverter_System.Models;
using Microsoft.EntityFrameworkCore;

namespace CurrentConverter_System.Data
{
    public class CurrencyDbContext :DbContext
    {
        public CurrencyDbContext(DbContextOptions<CurrencyDbContext> options) 
            : base(options)
        {
        }
        public DbSet<CurrencyConversion> Conversions { get; set; }
    }
}
