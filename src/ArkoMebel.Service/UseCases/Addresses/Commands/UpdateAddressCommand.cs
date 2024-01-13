namespace ArkoMebel.Service.UseCases.Addresses.Commands
{
    public class UpdateAddressCommand
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Home { get; set; }
    }
}
