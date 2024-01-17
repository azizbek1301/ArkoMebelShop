using System.Text.Json.Serialization;

namespace ArkoMebel.WebAPI.ViewModel
{
    public class BranchDto
    {
        public string Name { get; set; }
        public int OpenAt { get; set; }
        public int CloseAt { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int AddressId { get; set; }
        public string Link { get; set; } = default!;
    }
}
