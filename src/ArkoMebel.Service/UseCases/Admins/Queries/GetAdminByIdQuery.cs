using ArkoMebel.Domain.Entites;
using MediatR;

namespace ArkoMebel.Service.UseCases.Admins.Queries
{
    public class GetAdminByIdQuery:IRequest<Admin>
    {
        public int AdminId {  get; set; }
    }
}
