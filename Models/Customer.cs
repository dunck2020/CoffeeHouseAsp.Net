using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeHouse.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        [Column(TypeName = "nvarChar(100)")]
        public string CustomerName { get; set; }

        public string CustomerEmail { get; set; }

        [Required]
        public string CustomerPhone { get; set; }

        public int RewardPointTotal { get; set; }
    }
}
