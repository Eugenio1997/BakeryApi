namespace BakeryApi.Models
{
    public class Order
    {
        public int Nr_Order { get; set; }
        public DateTime DT_Order { get; set; }
        public string? Type { get; set; }
        public Client? Client { get; set; }
        public List<OrderItem>? Items { get; set; }

    }
}
