namespace HipHopPizza.Dtos
{
    public class OrderDto
    {
        public string? CustomerName { get; set; }
        public bool Closed { get; set; }
        public int CustomerPhone { get; set; }
        public string? CustomerEmail { get; set; }
        public string? Type { get; set; }
        public string? PaymentType { get; set; }
        public decimal Total { get; set; }
        public decimal Tip { get; set; }
    }
}