namespace ArkoMebel.Domain.Entites
{
    public class Prodact_Box
    {
        public int Id {  get; set; }
        public int ProductId {  get; set; }
        public int BoxId {  get; set; }
        public bool Status {  get; set; }

        public Product Product { get; set; }
        public Box Box { get; set; }

    }
}
