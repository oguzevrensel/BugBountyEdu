using BugBountyDevs.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugBountyDevs.Entity.Concretes
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        // Nav Property
        public virtual HashSet<Product> Products { get; set; } // Aynı Değerleri kabul etmez


        public Category()
        {
            Products = new HashSet<Product>();
        }
    }
}
