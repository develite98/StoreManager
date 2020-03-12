using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManager.Models
{
    public class Products
    {

        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter name of product")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Please enter description for this product")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter price")]
        public decimal Price { get; set; }

        public int Quantity { get; set; }

    }
}
