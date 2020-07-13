namespace Core.Entities.OrderAggregate
{
    public class Address
    {
        public Address()
        {
        }

        public Address(string firstName, string lastName, string street, string ward, string district, string zipcode)
        {
            FirstName = firstName;
            LastName = lastName;
            Street = street;
            Ward = ward;
            District = district;
            Zipcode = zipcode;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string Ward { get; set; }
        public string District { get; set; }
        public string Zipcode { get; set; }
    }
}