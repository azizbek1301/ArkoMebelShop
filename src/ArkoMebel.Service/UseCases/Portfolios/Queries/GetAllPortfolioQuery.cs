using ArkoMebel.Domain.Entites;
using MediatR;

namespace ArkoMebel.Service.UseCases.Portfolios.Queries
{
    public class GetAllPortfolioQuery:IRequest<List<Portfolio>>
    {
    }
}
