namespace Testing
{
    public class Address
    {
        public string Email { get; set; } 
        public string PhoneNumber { get; set; }
        public string HomeAddress { get; set; }
        public string OfficeAddress { get; set; }   
        
        public Address(string email, string phoneNumber, string homeAddress, string officeAddress)
        {
            Email = email;
            PhoneNumber = phoneNumber;
            HomeAddress = homeAddress;
            OfficeAddress = officeAddress;
        }

    }
}
