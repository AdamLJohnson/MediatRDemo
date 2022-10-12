using AutoMapper;
using MediatRDemo.Repositories;
using MediatRDemo.Responses;

namespace MediatRDemo.Services
{
    public interface IOrderService
    {
        Task<CustomerOrdersResponse> GetCustomersOrders(Guid customerId);
    }

    public sealed class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepository _orderRepository;

        public OrderService(IMapper mapper, IOrderRepository orderRepository)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
        }

        public async Task<CustomerOrdersResponse> GetCustomersOrders(Guid customerId)
        {
            var orders = await _orderRepository.GetOrdersForCustomer(customerId);
            return new CustomerOrdersResponse
            {
                CustomerId = customerId,
                Orders = _mapper.Map<List<OrderResponse>>(orders)
            };
        }
    }
}
