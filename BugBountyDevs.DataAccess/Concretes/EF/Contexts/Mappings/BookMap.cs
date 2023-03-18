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
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.BookId);
            builder.Property(x => x.BookName).HasMaxLength(50).HasColumnType("nvarchar").IsRequired();
            builder.ToTable(nameof(Book));
            builder.HasMany(x => x.Authors).WithOne();
        }
    }
}
