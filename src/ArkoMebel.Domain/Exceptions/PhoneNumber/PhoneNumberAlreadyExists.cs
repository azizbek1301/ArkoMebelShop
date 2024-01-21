namespace ArkoMebel.Domain.Exceptions.PhoneNumber
{
    public class PhoneNumberAlreadyExists:GlobalExceptions
    {
        public PhoneNumberAlreadyExists()
        {
            TitleMessage = "Phone Number Already Exists";
        }
    }
}
