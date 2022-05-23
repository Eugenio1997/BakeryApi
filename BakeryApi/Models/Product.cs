using System.ComponentModel.DataAnnotations.Schema;

namespace BakeryApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public int Stock { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Value { get; set; }
    }
}
