using BugBountyDevs.DataAccess.Abstracts;
using BugBountyDevs.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugBountyDevs.Businness.Concretes
{
    public class CategoryService : BaseService<Category>
    {
        public CategoryService(IBaseRepository<Category> baseRepository) : base(baseRepository)
        {
            
        }
    }
}
