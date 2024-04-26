using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCorePizza.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string Name { get; set; } = null;

        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
        
    }
}