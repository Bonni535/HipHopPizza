namespace hip_hop_pizza.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public List<OrderItem> Orders { get; set; } = new List<OrderItem>();

    }
}