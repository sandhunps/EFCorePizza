using System.ComponentModel.DataAnnotations;

namespace EFCorePizza.Models
{
    public class Customer
    {   
        [Key]
        public int CustomerID { get; set;}

        public string FirstName { get; set; } = null;   

        public string LastName { get; set; } = null;

        public string? Address { get; set; } 

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public List<Order> Orders { get; set; } = null;
    }

}