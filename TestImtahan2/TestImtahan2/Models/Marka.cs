using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestImtahan2.Models
{
    public class Marka
    {
        public int Id { get; set; }
        [Required]
        public string MarkaName { get; set; }
        public List<Car> Cars { get; set; }
    }
}
