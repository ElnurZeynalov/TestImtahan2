using System.ComponentModel.DataAnnotations;

namespace TestImtahan2.Models
{
    public class Brand
    {
        public int Id { get; set; }
        [Required]
        public string BrandName { get; set; }
    }
}
