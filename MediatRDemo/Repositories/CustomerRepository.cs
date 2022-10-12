using MediatRDemo.Dtos;

namespace MediatRDemo.Repositories
{
    public interface ICustomerRepository
    {
        Task<CustomerDto> GetCustomerAsync(Guid customerId);
        Task<List<CustomerDto>> GetCustomersAsync();
    }

    public sealed class CustomerRepository : ICustomerRepository
    {
        public readonly List<CustomerDto> _customers = new List<CustomerDto>
        {
            new CustomerDto{ Id = Guid.Parse("bee7cb01-421d-4fbe-bf91-032c3494baa9"), Name = "Adam Johnson", Address = "1234 Main Street", City = "Test Town", State = "CA", PostalCode = "12345" },
            new CustomerDto{ Id = Guid.Parse("d22d6846-76cc-41c8-a426-ddb28050290e"), Name = "Bob Gildersleve", Address = "7745 Happy Street", City = "Test Town", State = "CA", PostalCode = "12345" }
        };

        public Task<CustomerDto> GetCustomerAsync(Guid customerId)
        {
            return Task.FromResult(_customers.SingleOrDefault(c => c.Id == customerId));
        }

        public Task<List<CustomerDto>> GetCustomersAsync()
        {
            return Task.FromResult(_customers);
        }
    }
}
