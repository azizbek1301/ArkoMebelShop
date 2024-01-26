using ArkoMebel.Domain.Dtos.Admins;
using MediatR;

namespace ArkoMebel.Service.UseCases.Admins.Commands
{
    public class UpdateAdminCommand:UpdateAdminDto,IRequest<int>
    {
    }
}
