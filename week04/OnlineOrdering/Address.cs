using System;

namespace OnlineOrdering
{
    class Address
    {
        private string Street { get; set; }
        private string City { get; set; }
        private string State { get; set; }
        private string Zip { get; set; }
        private string Country { get; set; }
        private bool IsUSAddress { get; set; }

        public Address(string street, string city, string state, string zip, string country)
        {
            Street = street;
            City = city;
            State = state;
            Zip = zip;
            Country = country;
            IsUSAddress = Country == "US";
        }
        public bool USBased()
        {
            if (!IsUSAddress)
            {
                return false;
            }
            return true;
        }
        public void GetDisplayText()
        {
            Console.WriteLine($"Address: {Street}, {City}, {State}, {Zip}, {Country}");
        }
    }
}