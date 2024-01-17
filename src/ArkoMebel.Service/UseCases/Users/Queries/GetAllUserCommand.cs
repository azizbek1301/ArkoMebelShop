using ArkoMebel.Domain.Entites;
using MediatR;

namespace ArkoMebel.Service.UseCases.Users.Queries
{
    public class GetAllUserCommand:IRequest<List<User>>
    {
    }
}
