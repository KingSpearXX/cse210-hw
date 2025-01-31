using System;

namespace OnlineOrdering
{
    class Customer
    {
        private string Name { get; set; }
        private string Email { get; set; }
        private string Phone { get; set; }
        private Address _Address { get; set; }
       

        public Customer(string name, string email, string phone, Address address)
        {
            Name = name;
            Email = email;
            Phone = phone;
            _Address = address;
        }
        public bool USA()
        {
            return _Address.USBased();
        }
        public void GetDisplayText()
        {
            Console.WriteLine($"Customer: {Name}, {Email}, {Phone}");
            _Address.GetDisplayText();
        }
    }
}