using ThirdGroup_1.Models;
using ThirdGroup_1.Repositories.EmployeeRepository;
using ThirdGroup_1.Repositories.Roles;
using ThirdGroup_1.Repositories.Users;

namespace ThirdGroup_1.Repositories.Base
{
    public interface IUnitOfWork
    {
        IEmployeeRepository Employees { get; }
        IRoleRepository Roles { get; }
        IUserRepository Users { get; }
        IRepository<Department> Departments { get; }
        IRepository<Category> Categories { get; }
        IRepository<Permission> Permissions { get; }
        IRepository<Product> Products { get; }
        int Save();
    }
}
