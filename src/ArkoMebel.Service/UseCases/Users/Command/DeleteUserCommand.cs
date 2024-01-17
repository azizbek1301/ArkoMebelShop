using MediatR;

namespace ArkoMebel.Service.UseCases.Users.Command
{
    public class DeleteUserCommand:IRequest<bool>
    {
        public int Id { get; set; }
    }
}
