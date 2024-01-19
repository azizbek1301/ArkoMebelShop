using ArkoMebel.Domain.Entites;
using MediatR;

namespace ArkoMebel.Service.UseCases.Comments.Queries
{
    public class GetAllCommentQuery:IRequest<List<Comment>>
    {
    }
}
