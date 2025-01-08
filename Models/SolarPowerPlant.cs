using System.ComponentModel.DataAnnotations;

namespace WeatherForecastAPI.Models
{
    public class SolarPowerPlant
    {
        [Key]
        [Required]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }

        [Required]
        public double Power { get; set; }
        [Required]
        public DateTime InstallationDate { get; set; }
        [Required]
        public double Longitude { get; set; }
        [Required]
        public double Latitude { get; set; }
    }
}
