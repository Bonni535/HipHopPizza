namespace hip_hop_pizza.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string? CustomerName { get; set; }
        public bool IsClosed { get; set; }
        public int CustomerPhone { get; set; }
        public string? CustomerEmail { get; set; }
        public string? Type { get; set; }
        public string? PaymentType { get; set; }
        public decimal Total { get; set; }
        public decimal Tip { get; set; }
        public DateTime CloseOrderDate { get; set; }
        public int UserId { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

    }
}