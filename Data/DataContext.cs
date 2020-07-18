using GoogleMappApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GoogleMappApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        }

        public DbSet<Location> Locations { get; set; }
    }
}
