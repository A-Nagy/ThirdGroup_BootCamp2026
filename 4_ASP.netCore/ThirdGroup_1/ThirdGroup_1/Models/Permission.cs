using System.ComponentModel.DataAnnotations;

namespace ThirdGroup_1.Models
{
    public class Permission
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }=string.Empty;

        public ICollection<Role>? Roles { get; set; }

      


    }
}
