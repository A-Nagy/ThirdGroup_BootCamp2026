using ThirdGroup_1.Models;
using ThirdGroup_1.Repositories.Base;

namespace ThirdGroup_1.Repositories.EmployeeRepository
{
    public interface IEmployeeRepository : IRepository<Employee> 
    {
        IEnumerable<Employee> GetAllWithDepartments();

        Employee GetEmployeebyName(string Name);


    }
}
