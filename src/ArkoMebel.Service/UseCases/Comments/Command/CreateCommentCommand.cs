using MediatR;

namespace ArkoMebel.Service.UseCases.Comments.Command
{
    public class CreateCommentCommand:IRequest
    {
        public string UserName { get; set; }
        public string Text { get; set; }
        public int ProductId { get; set; }
        public string? PhotoPath { get; set; } = default!;

    }
}
