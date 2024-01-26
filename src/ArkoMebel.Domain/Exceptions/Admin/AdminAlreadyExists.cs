namespace ArkoMebel.Domain.Exceptions.Admin
{
    public class AdminAlreadyExists:GlobalExceptions
    {
        public AdminAlreadyExists()
        {
            TitleMessage = "Admin Already Exists!";
        }
    }
}
