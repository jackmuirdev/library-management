
using System.ComponentModel.DataAnnotations;

namespace Backend.DTOs
{
    public class UpdateProductDto
    {
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(100, Double.PositiveInfinity)]
        public long Price { get; set; }
        public IFormFile File { get; set; }
        [Required]
        public string Category  { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Range(0, 200)]
        public int QuantityInStock { get; set; }
    }
}