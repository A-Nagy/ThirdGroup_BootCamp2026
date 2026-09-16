using System.ComponentModel.DataAnnotations;

namespace ThirdGroup_1.Models
{
    public class User
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string? Email { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; } =string.Empty;
        public string Password { get; set; } = string.Empty;

        public ICollection<Role>? Roles { get; set; }




    }
}
