using MediatR;

namespace ArkoMebel.Service.UseCases.Users.Command
{
    public class UpdateUserCommand:IRequest<bool>
    { 
        public int Id {  get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public string RefreshToken { get; set; }
    }
}
