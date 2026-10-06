using ThirdGroup_1.Models;
using ThirdGroup_1.Repositories.Base;

namespace ThirdGroup_1.Repositories.Users
{
    public interface IUserRepository : IRepository<User>
    {
        User GetByUserName(string UserName);
        User GetUserWithRoleAndPermission(string UserName);
        User GetUserWithRole(int Id);

    }
}
