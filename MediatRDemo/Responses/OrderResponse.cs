namespace MediatRDemo.Responses
{
    public class OrderResponse
    {
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        public Guid CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public bool Delivered { get; set; }
    }
}
