namespace hip_hop_pizza.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Order? Order { get; set; }
        public Item? Item { get; set; }
 
    }
}