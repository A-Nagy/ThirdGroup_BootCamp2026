using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using ThirdGroup_1.Data;
using ThirdGroup_1.Models;
using ThirdGroup_1.Repositories.Base;

namespace ThirdGroup_1.Repositories.Roles
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(AppDbContext db) : base(db)
        {
        }

        public Role? GeRoleWithPermissions(int Id)
        {
           return _context.Roles.Include(r=>r.Permissions).FirstOrDefault(r=>r.Id==Id);
        }

        public IEnumerable<Role> GetSpecificUserRoles(List<int> roleIds)
        {
            return _context.Roles.Where(r => roleIds.Contains(r.Id)).ToList();
        }
    }
}
