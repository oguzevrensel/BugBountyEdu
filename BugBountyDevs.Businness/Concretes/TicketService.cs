using BugBountyDevs.DataAccess.Abstracts;
using BugBountyDevs.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugBountyDevs.Businness.Concretes
{
    public class TicketService : BaseService<Ticket>
    {
        public TicketService(IBaseRepository<Ticket> baseRepository) : base(baseRepository)
        {
            
        }
    }
}
