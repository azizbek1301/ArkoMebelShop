using MediatR;

namespace ArkoMebel.Service.UseCases.Addresses.Commands
{
    public class CreateAddressCommand:IRequest
    {
        public string City { get; set; }
        public string Home { get; set; }
    }
}
