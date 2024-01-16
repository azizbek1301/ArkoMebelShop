using ArkoMebel.Domain.Enums;

namespace ArkoMebel.Domain.Entites
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Color Color {  get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId {  get; set; }

        public Category Category {  get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Likes> Likes { get; set; }
    }
}
