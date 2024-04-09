namespace HipHopPizza.Dtos
{
    public class OrderDto
    {
        public string Name { get; set; }
        public bool Closed { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
        public string PaymentType { get; set; }
        public int Total { get; set; }
        public int Tip { get; set; }
    }
}