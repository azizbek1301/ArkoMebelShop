namespace Authorisation.API.Exceptions
{
    public class UserNotFoundException:Exception
    {
        public string TitleMessage {  get; set; }
        public UserNotFoundException()
        {
            TitleMessage = "User Not Found";
        }
    }
}
