using MediatRDemo.Responses;
using MediatRDemo.Repositories;
using AutoMapper;

namespace MediatRDemo.Services
{
    public interface ICustomerService
    {
        Task<CustomerResponse> GetCustomerAsync(Guid customerId);
        Task<List<CustomerResponse>> GetCustomersAsync();
    }

    public sealed class CustomerService : ICustomerService
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(IMapper mapper, ICustomerRepository customerRepository)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }

        public async Task<CustomerResponse> GetCustomerAsync(Guid customerId)
        {
            return _mapper.Map<CustomerResponse>(await _customerRepository.GetCustomerAsync(customerId));
        }

        public async Task<List<CustomerResponse>> GetCustomersAsync()
        {
            return _mapper.Map<List<CustomerResponse>>(await _customerRepository.GetCustomersAsync());
        }
    }
}
