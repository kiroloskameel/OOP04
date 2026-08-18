using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    public struct DeliveryAddress
    {
        public string Street { get; set; }
        public string City { get; set; }

        public DeliveryAddress(string street, string city)
        {
            Street = street;
            City = city;
        }
    }
}
