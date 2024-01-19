using MediatR;

namespace ArkoMebel.Service.UseCases.ProductBoxes.Command
{
    public class CreateProductBoxCommand :IRequest
    {
        public int ProductId { get; set; }
        public int BoxId { get; set; }
        public bool Status { get; set; }
    }
}
