using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManager.Models
{
    public class Bills
    {
        public Bills()
        {
            Products = new HashSet<Products>();
        }

        public int ID { get; set; }

        public decimal totalPrice { get; set; }

        public ICollection<Products> Products { get; set; }
    }
}
