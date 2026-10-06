using ThirdGroup_1.Data;
using ThirdGroup_1.Models;
using ThirdGroup_1.Repositories.EmployeeRepository;
using ThirdGroup_1.Repositories.Roles;
using ThirdGroup_1.Repositories.Users;

namespace ThirdGroup_1.Repositories.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IEmployeeRepository Employees  { get; }

        public IRoleRepository Roles { get; }

        public IUserRepository Users { get; }

        public IRepository<Department> Departments { get; }

        public IRepository<Category> Categories { get; }

        public IRepository<Permission> Permissions { get; }

        public IRepository<Product> Products { get; }

        public UnitOfWork(AppDbContext context) 
        {
            _context    = context;
            Employees   = new ThirdGroup_1.Repositories.EmployeeRepository.EmployeeRepository(_context);
            Roles       = new RoleRepository(_context);
            Users       = new UserRepository(_context);
            Permissions = new Repository<Permission>(_context);
            Categories  = new Repository<Category>(_context);
            Departments = new Repository<Department>(_context);
            Products    = new Repository<Product>(_context);

        }
        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
