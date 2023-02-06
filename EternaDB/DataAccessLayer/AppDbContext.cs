using EternaDB.Models;
using Microsoft.EntityFrameworkCore;

namespace EternaDB.DataAccessLayer
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        public DbSet<Teams> Teams { get; set; } 
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Service> Services { get; set; } 
        public DbSet<PricingService> PricingService { get; set; }
    }
}
