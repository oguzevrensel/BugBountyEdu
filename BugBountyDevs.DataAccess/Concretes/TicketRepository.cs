﻿using BugBountyDevs.DataAccess.Abstracts;
using BugBountyDevs.DataAccess.Concretes.EF.Contexts;
using BugBountyDevs.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugBountyDevs.DataAccess.Concretes
{
    internal class TicketRepository : BaseRepository<Ticket, BugBountyContext> , ITicketRepository
    {
    }
}
