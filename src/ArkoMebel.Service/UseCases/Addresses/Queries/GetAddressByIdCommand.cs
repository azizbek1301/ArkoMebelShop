using ArkoMebel.Domain.Entites;
using MediatR;

namespace ArkoMebel.Service.UseCases.Addresses.Queries
{
    public class GetAddressByIdCommand:IRequest<Address>
    {
        public int Id {  get; set; }
    }
}
