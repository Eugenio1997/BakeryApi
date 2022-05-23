using System.ComponentModel.DataAnnotations.Schema;

namespace BakeryApi.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Unitary_Value { get; set; }
        public Product? Product { get; set; }
    }
}
