using System.ComponentModel.DataAnnotations;
using WebAPIDemo.Models.Validations;

namespace WebAPIDemo.Models
{
    public class Shirt
    {
        public int ShirtId { get; set; }
        [Required]
        public string? BrandName { get; set; }
        [Required]
        public string? Color { get; set; }

        [Shirt_EnsureSize]
        public int? Size { get; set; }

        [Required]
        public string? Gender { get; set; }
        public double? Price { get; set; }

    }
}
