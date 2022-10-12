namespace MediatRDemo.Responses
{
    public class CustomerOrdersResponse
    {
        public Guid CustomerId { get; set; }
        public List<OrderResponse> Orders { get; set; }
    }
}
