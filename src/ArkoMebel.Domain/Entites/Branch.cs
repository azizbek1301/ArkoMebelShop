namespace ArkoMebel.Domain.Entites
{
    public class Branch
    {
        public int Id {  get; set; }
        public string Name {  get; set; }
        public TimeOnly OpenAt { get; set; }
        public TimeOnly CloseAt { get; set; }
        public string PhoneNumber { get; set; }
        public string Email {  get; set; }
        public int AddressId {  get; set; }
        public string Link { get; set; } = default!;// telegram uchun

        public Address Address { get; set; }
    }
}
