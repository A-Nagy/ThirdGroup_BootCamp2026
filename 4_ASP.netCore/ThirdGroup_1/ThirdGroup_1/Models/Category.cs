using System.ComponentModel.DataAnnotations;

namespace ThirdGroup_1.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        public string Name { get; set; }= string.Empty;

        public string? Description { get; set; }
        
        public ICollection<Product>? Products { get; set; }
    }
}
