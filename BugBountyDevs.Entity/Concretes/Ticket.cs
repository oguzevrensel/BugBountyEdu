using BugBountyDevs.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugBountyDevs.Entity.Concretes
{
    public class Ticket : IEntity
    {
        public int TicketId { get; set; }

        public string TicketName { get; set;}

        // Nav Property
        public virtual User User { get; set; }
    }
}
