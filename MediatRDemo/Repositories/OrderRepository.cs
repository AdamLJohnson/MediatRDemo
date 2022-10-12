using MediatRDemo.Dtos;

namespace MediatRDemo.Repositories
{
    public interface IOrderRepository
    {
        Task<List<OrderDto>> GetOrdersForCustomer(Guid customerId);
    }

    public class OrderRepository : IOrderRepository
    {
        private readonly List<OrderDto> _orders = new List<OrderDto>
        {
            new OrderDto{ 
                Id = Guid.Parse("d78fd138-a17e-457f-ba31-408a37ed8d86"), 
                CustomerId = Guid.Parse("bee7cb01-421d-4fbe-bf91-032c3494baa9"),
                ProductId = Guid.NewGuid(),
                OrderDate = DateTime.UtcNow
            }
        };
        public Task<List<OrderDto>> GetOrdersForCustomer(Guid customerId)
        {
            return Task.FromResult(_orders.Where(o => o.CustomerId == customerId).ToList());
        }
    }
}
