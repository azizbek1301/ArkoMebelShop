using MediatR;

namespace ArkoMebel.Service.UseCases.Comments.Command
{
    public class DeleteCommentCommand:IRequest<bool>
    {
        public int Id { get; set; }

    }
}
