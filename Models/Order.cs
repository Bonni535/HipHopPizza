namespace hip_hop_pizza.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Closed { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
        public string PaymentType { get; set; }
        public int Total { get; set; }
        public int Tip { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

    }
}