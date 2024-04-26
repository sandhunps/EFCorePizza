using System.ComponentModel.DataAnnotations;

namespace  EFCorePizza.Models
{    public class Order
    {   
        [Key]
        public int OrderId { get; set; }

        public DateTime OrderPlaced { get; set; }

        public DateTime? OrderFulfilled { get; set; }

        public int CustomerID { get; set; }

        public Customer Customer { get; set; } = null;

        public List<OrderDetails> OrderDetails { get; set; }
        
    }
}
