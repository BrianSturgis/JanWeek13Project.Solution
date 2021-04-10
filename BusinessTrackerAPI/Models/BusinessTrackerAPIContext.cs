using Microsoft.EntityFrameworkCore;

namespace BusinessTrackerAPI.Models
{
    public class BusinessTrackerAPIContext : DbContext
    {
        public BusinessTrackerAPIContext(DbContextOptions<BusinessTrackerAPIContext> options)
            : base(options)
        {
        }
        public DbSet<Business> Businesses { get; set; }
    }
}