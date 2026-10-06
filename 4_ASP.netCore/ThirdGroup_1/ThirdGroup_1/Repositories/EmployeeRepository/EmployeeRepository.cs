using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using ThirdGroup_1.Data;
using ThirdGroup_1.Models;
using ThirdGroup_1.Repositories.Base;

namespace ThirdGroup_1.Repositories.EmployeeRepository
{
    public class EmployeeRepository : Repository<Employee> , IEmployeeRepository
    {
      public EmployeeRepository(AppDbContext context) : base(context)
        {}
 
        public IEnumerable<Employee> GetAllWithDepartments()
        {
            IEnumerable<Employee> empdata = _context.Employees.Include(e => e.Department).ToList();
            return empdata;
        }
 

        public Employee GetEmployeebyName(string Name)
        {
            Employee? emp = _context.Employees.FirstOrDefault(d => Name == d.EmployeeName);
            return emp;
        }


    }
}
