using ArkoMebel.Domain.Entites;
using MediatR;

namespace ArkoMebel.Service.UseCases.Like.Queries
{
    public class GetAllLikeQuery : IRequest<List<Likes>>
    {
    }
}
