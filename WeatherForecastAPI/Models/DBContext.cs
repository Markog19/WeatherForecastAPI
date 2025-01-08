
using Microsoft.EntityFrameworkCore;

namespace WeatherForecastAPI.Models
{
    public class DBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<SolarPowerPlant> SolarPowerPlants { get; set; }

    }
}
