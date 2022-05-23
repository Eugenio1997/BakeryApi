namespace BakeryApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public int Stock { get; set; }
        public decimal Value { get; set; }
    }
}
