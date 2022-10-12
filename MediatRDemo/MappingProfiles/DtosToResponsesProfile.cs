using AutoMapper;
using MediatRDemo.Dtos;
using MediatRDemo.Responses;

namespace MediatRDemo.MappingProfiles
{
    public class DtosToResponsesProfile : Profile
    {
        public DtosToResponsesProfile()
        {
            CreateMap<CustomerDto, CustomerResponse>();
            CreateMap<OrderDto, OrderResponse>();
        }
    }
}
