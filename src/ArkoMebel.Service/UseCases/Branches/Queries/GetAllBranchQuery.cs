using ArkoMebel.Domain.Entites;
using MediatR;

namespace ArkoMebel.Service.UseCases.Branches.Queries
{
    public class GetAllBranchQuery:IRequest<List<Branch>>
    {
    }
}
