using System.ComponentModel.DataAnnotations;

namespace ThirdGroup_1.Models
{
    public class Role
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        public ICollection<Permission>? Permissions { get; set; }
        public ICollection<User>? Users { get; set; }


    }
}
