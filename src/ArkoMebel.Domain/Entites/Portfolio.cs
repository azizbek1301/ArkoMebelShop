namespace ArkoMebel.Domain.Entites
{
    public class Portfolio
    {
        public int Id {  get; set; }
        public string PhotoPath {  get; set; }
        public int CategoryId {  get; set; }
        public Category Category { get; set; }
    }
}
