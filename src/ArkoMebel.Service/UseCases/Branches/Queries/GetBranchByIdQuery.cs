using ArkoMebel.Domain.Entites;
using MediatR;

namespace ArkoMebel.Service.UseCases.Branches.Queries
{
    public class GetBranchByIdQuery:IRequest<Branch>
    {
        public int Id { get; set; } 
    }
}
