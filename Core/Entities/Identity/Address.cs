namespace Core.Entities.Identity
{
    public class Address
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string Ward { get; set; }
        public string District { get; set; }
        public string Zipcode { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}