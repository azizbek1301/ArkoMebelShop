using MediatR;

namespace ArkoMebel.Service.UseCases.Orders.Command
{
    public class CreateOrderCommand:IRequest
    {
        public int BoxId {  get; set; }
        public int AddressId {  get; set; }
    }
}
