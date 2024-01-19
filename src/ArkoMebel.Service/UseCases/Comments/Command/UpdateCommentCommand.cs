using MediatR;

namespace ArkoMebel.Service.UseCases.Comments.Command
{
    public class UpdateCommentCommand:IRequest<bool>
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string UserName { get; set; }
        public string Text { get; set; }
        public string? PhotoPath { get; set; } = default!;
    }
}
