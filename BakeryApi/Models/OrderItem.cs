namespace BakeryApi.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Unitary_Value { get; set; }
        public Product? Product { get; set; }
    }
}
