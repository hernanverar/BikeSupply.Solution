using Microsoft.EntityFrameworkCore;

namespace BikeSupply.Models
{
  public class BikeSupplyContext : DbContext
  {
    public DbSet<Bike> Bikes { get; set; }
    public BikeSupplyContext(DbContextOptions options) : base(options) { }
  }

}