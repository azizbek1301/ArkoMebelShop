using ArkoMebel.Domain.Entites;
using MediatR;

namespace ArkoMebel.Service.UseCases.ProductBoxes.Queries
{
    public class GetAllProductBoxQuery:IRequest<List<Prodact_Box>>
    {
    }
}
