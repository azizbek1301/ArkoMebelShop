namespace ArkoMebel.Domain.Entites
{
    public class Box
    {
        public int Id {  get; set; }
        public int UserId {  get; set; }
        public List<Product> Products { get; set; }
    }
}
