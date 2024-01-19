using ArkoMebel.Domain.Entites;
using MediatR;

namespace ArkoMebel.Service.UseCases.Productes.Queries
{
    public class GetAllProductQuery : IRequest<List<Product>>
    {
    }
}
