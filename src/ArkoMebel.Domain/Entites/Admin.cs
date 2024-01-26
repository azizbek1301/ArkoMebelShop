using ArkoMebel.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace ArkoMebel.Domain.Entites
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public Role Role { get; set; }
    }
}
