using MediatR;

namespace ArkoMebel.Service.UseCases.Like.Command
{
    public class CreateLikeCommand:IRequest
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
    }
}
