namespace ArkoMebel.Domain.Entites
{
    public class Photo
    {
        public int Id { get; set; }
        public string PhotoPath {  get; set; }
        public int ProductId {  get; set; }

        public Product Product { get; set; }    
    }
}
