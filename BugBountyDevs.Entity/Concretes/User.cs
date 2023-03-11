using BugBountyDevs.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugBountyDevs.Entity.Concretes
{
    public class User : IEntity
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        // Navigation Property
        public virtual int TicketId { get; set; }

        public virtual Ticket Ticket { get; set; }
    }
}
