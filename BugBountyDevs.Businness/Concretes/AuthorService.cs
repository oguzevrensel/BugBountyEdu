using BugBountyDevs.DataAccess.Abstracts;
using BugBountyDevs.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugBountyDevs.Businness.Concretes
{
    public class AuthorService : BaseService<Author>
    {
        public AuthorService(IBaseRepository<Author> baseRepository) : base(baseRepository)
        {
            
        }
    }
}
