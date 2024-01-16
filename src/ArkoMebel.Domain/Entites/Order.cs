namespace ArkoMebel.Domain.Entites
{
    public class Order
    {

        public int Id { get; set; }
        
        public int BoxId {  get; set; }
        public Box Box { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
