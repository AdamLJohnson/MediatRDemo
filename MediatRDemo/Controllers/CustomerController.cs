using MediatRDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace MediatRDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IOrderService _orderService;

        public CustomerController(ICustomerService customerService, IOrderService orderService)
        {
            _customerService = customerService;
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<IResult> GetCustomers()
        {
            var customers = await _customerService.GetCustomersAsync();
            return Results.Ok(customers);
        }

        [HttpGet("{customerId}")]
        public async Task<IResult> GetCustomer(Guid customerId)
        {
            var customer = await _customerService.GetCustomerAsync(customerId);
            return customer != null ? Results.Ok(customer) : Results.NotFound();
        }

        [HttpGet("{customerId}/orders")]
        public async Task<IResult> GetCustomerOrders(Guid customerId)
        {
            var results = await _orderService.GetCustomersOrders(customerId);
            return Results.Ok(results);
        }
    }
}