using Authorisation.API.Enums;
using System.Text.Json.Serialization;

namespace Authorisation.API.Models
{
    public class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }
        [JsonIgnore]
        public Role Role { get; set; }
    }
}
