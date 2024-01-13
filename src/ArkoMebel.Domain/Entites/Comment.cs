namespace ArkoMebel.Domain.Entites
{
    public class Comment
    {
        public int Id { get; set; }
        public int ProductId {  get; set; }
        public string UserName {  get; set; }
        public string Text { get; set; }
        public string? PhotoPath { get; set; } 
    }
}
