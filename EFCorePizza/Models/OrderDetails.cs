namespace EFCorePizza.Models
{
    public class OrderDetails
    { 
        public int Id { get; set; }

        public int Quantity { get; set; }

        public int ProductId { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; } = null;

        public Product Product { get; set; } = null;
        
    }
}