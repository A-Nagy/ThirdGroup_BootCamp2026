using System.ComponentModel.DataAnnotations;

namespace ThirdGroup_1.Models
{
    public class Employee
    //Data Annotations are used to define metadata for the properties of the Employee class.
    //These annotations provide additional information about the properties,
    //such as validation rules and constraints.
    {
        [Key]// This attribute indicates that the property is the primary key of the entity.
        public int EmployeeId { get; set; }
        [Required]// This attribute indicates that the property is required and cannot be null.not null.
        public string EmployeeName { get; set; }  = string.Empty;
        public string? EmployeeEmail { get; set; }
        [StringLength(11)]// This attribute specifies the maximum length of the string property.
        public string? EmployeePhone { get; set; }
        public int EmployeeAge { get; set; }
        [Required]
        [Range(3000,10000, ErrorMessage = "Salary must be between 3000 and 10000.")]
        // This attribute specifies that the property is required and must fall within the specified range.
        public decimal EmployeeSalary { get; set; }

        public int? DepartmentId { get; set; }
       
        //Navigation Property 
        public Department? Department { get; set; }

    }
}
