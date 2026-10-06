using ThirdGroup_1.Models;
using ThirdGroup_1.Repositories.Base;

namespace ThirdGroup_1.Repositories.Roles
{
    public interface IRoleRepository : IRepository<Role>
    {
        Role? GeRoleWithPermissions(int Id);
        IEnumerable<Role> GetSpecificUserRoles(List<int> roleIds);
    }
}
