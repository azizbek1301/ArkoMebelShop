using ArkoMebel.Domain.Enums;
using MediatR;

namespace ArkoMebel.Service.UseCases.Productes.Command
{
    public class CreateProductCommand : IRequest
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
