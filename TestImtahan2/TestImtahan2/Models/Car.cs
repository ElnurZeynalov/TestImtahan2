using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestImtahan2.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Required]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        [Required]
        public int MarkaId { get; set; }
        public Marka Marka { get; set; }
        [Required]
        public int Door { get; set; }
        [Required]
        public int Seat { get; set; }
        [Required]
        public bool AirConduction { get; set; }
        public int Age { get; set; }
        [Required]
        public int TransmisionId { get; set; }
        public Transmision Transmision { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [NotMapped,Required]
        public IFormFile Image { get; set; }
    }
}
