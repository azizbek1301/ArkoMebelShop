namespace ArkoMebel.WebAPI.ViewModel
{
    public class CommentDto
    {
        public int ProductId { get; set; }
        public string UserName { get; set; }
        public string Text { get; set; }
        public string? PhotoPath { get; set; }
    }
}
