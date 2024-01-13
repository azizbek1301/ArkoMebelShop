using MediatR;

namespace ArkoMebel.Service.UseCases.Addresses.Commands
{
    public class DeleteAddressCommand:IRequest<bool>
    {
        public int Id {  get; set; }
    }
}
