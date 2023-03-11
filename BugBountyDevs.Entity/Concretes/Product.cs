using BugBountyDevs.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugBountyDevs.Entity.Concretes
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public decimal UnitPrice { get; set; } // Para Birimi Karşılığı => decimal
        // Nav Property
        public virtual int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
