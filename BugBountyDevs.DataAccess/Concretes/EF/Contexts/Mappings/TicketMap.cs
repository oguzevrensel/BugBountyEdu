using BugBountyDevs.Entity.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugBountyDevs.DataAccess.Concretes.EF.Contexts.Mappings
{
    public class TicketMap : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(x => x.TicketId);
            builder.Property(x => x.TicketName).HasMaxLength(100).HasColumnType("nvarchar").IsRequired();
            builder.ToTable(nameof(Ticket));

            builder.HasOne(x => x.User);
        }
    }
}
