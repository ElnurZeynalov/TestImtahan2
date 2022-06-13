using System.ComponentModel.DataAnnotations;

namespace TestImtahan2.Models
{
    public class Transmision
    {
        public int Id { get; set; }
        [Required]
        public string TransmisionName { get; set; }
    }
}
