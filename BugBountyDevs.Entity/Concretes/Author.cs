using BugBountyDevs.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugBountyDevs.Entity.Concretes
{
    public class Author : IEntity
    {

        public int AuthorId { get; set; }

        public string AuthorName { get; set; }


        // Nav Property
        

        public virtual HashSet<Book> Books { get; set; }  // Override edilebilmesi için virtual

        public Author()
        {
            Books = new HashSet<Book>(); // Books'da NullPointer hatası almamak için
        }

        
    }
}
