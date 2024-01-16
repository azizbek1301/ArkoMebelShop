namespace ArkoMebel.Domain.Entites
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhotoPath { get; set; } = null;
        

        public ICollection<Product> Products { get; set; }
    }
}
