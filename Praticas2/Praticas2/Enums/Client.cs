using System;
using System.Collections.Generic;
using System.Text;

namespace Praticas2.Enums
{
    class Client
    {
        public string  Name { get; set; }
        public string Email { get; set; }
        public DateTime birthDate { get; set; } //birthDate = DateTime?

        public Client()
        {
        }

        public Client(string Name, string Email, DateTime birthDate)
        {
            Name = Name;
            Email = Email;
            birthDate = birthDate;
        }
    }
    
}
