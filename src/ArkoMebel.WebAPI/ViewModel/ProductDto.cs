using ArkoMebel.Domain.Enums;

namespace ArkoMebel.WebAPI.ViewModel
{
    public class ProductDto
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
