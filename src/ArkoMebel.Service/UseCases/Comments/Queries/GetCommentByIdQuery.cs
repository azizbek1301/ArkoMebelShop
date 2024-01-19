using ArkoMebel.Domain.Entites;
using MediatR;

namespace ArkoMebel.Service.UseCases.Comments.Queries
{
    public class GetCommentByIdQuery:IRequest<Comment>
    {
        public int Id {  get; set; }
    }
}
