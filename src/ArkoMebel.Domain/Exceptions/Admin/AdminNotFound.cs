namespace ArkoMebel.Domain.Exceptions.Admin
{
    internal class AdminNotFound:GlobalExceptions
    {
        public AdminNotFound()
        {
            TitleMessage = "Admin Not Found!";
        }
    }
}
