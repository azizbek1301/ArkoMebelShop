using ArkoMebel.Domain.Entites;
using MediatR;

namespace ArkoMebel.Service.UseCases.Admins.Queries
{
    public class GetAllAdminQuery:IRequest<List<Admin>>
    {
    }
}
