using ArkoMebel.Domain.Entites;
using MediatR;

namespace ArkoMebel.Service.UseCases.Orders.Queries
{
    public class GetAllOrderQuery : IRequest<List<Order>>
    {
    }
}
