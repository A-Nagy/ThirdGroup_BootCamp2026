using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using ThirdGroup_1.Data;
using ThirdGroup_1.Models;
using ThirdGroup_1.Repositories.Base;

namespace ThirdGroup_1.Repositories.Users
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AppDbContext db) : base(db)
        {}

        public User? GetByUserName(string UserName)
        {
          return  _context.Users.FirstOrDefault(u => u.UserName == UserName);
        }

        public User GetUserWithRole(int Id)
        {
            return _context.Users
                           .Include(u => u.Roles)
                           .FirstOrDefault(u => u.Id == Id);
        }

        public User GetUserWithRoleAndPermission(string UserName)
        {
            return _context.Users
                            .Include(u=>u.Roles)
                            .ThenInclude(r=>r.Permissions)
                            .FirstOrDefault(u => u.UserName == UserName);
        }
    }
}
