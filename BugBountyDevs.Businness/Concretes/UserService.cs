using BugBountyDevs.DataAccess.Abstracts;
using BugBountyDevs.Entity.Concretes;


namespace BugBountyDevs.Businness.Concretes
{
    public class UserService : BaseService<User>
    {
        public UserService(IBaseRepository<User> baseRepository) : base(baseRepository)
        {
            
        }
    }
}
