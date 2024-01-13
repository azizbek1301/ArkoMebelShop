using ArkoMebel.Domain.Entites;
using MediatR;

namespace ArkoMebel.Service.UseCases.Addresses.Queries
{
    public class GetAllAddressCommand : IRequest<List<Address>>
    {
    }
}
