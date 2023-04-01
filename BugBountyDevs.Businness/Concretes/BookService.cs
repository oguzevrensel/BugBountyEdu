using BugBountyDevs.DataAccess.Abstracts;
using BugBountyDevs.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugBountyDevs.Businness.Concretes
{
    public class BookService : BaseService<Book>
    {
        public BookService(IBaseRepository<Book> baseRepository) : base(baseRepository) 
        {
            
        }
    }
}
