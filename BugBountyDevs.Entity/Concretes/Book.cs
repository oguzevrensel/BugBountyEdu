using BugBountyDevs.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugBountyDevs.Entity.Concretes
{
    public class Book : IEntity
    {
        public int BookId { get; set; }

        public string BookName { get; set; }
        // Nav Property
        public virtual int AuthorId { get; set; }
        // Nav Property
        public virtual HashSet<Author> Authors { get; set; }

        public Book()
        {
            Authors = new HashSet<Author>();
        }

    }
}
