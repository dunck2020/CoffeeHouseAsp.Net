using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeHouse.Models
{
    public class OrderManager
    {
        [Key]
        public int OrderManagerID { get; set; }
        public int ProductID { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
        public List<Product> ProductList { get; set; }
        public decimal OrderTotal { get; set; }
        public int OrderRewardPointTotal { get; set; }

    }
}
