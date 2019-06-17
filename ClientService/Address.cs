namespace ClientService
{
    public class Address
    {

        public string street { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }

        public Address(string street, string city, int postalCode)
        {
            this.City = city;
            this.street = street;
            this.PostalCode = postalCode;
        }
    }
}