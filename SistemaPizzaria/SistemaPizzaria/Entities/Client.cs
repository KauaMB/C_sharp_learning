using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaPizzaria.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Client(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"{Name}, {PhoneNumber}";
        }
    }
}

