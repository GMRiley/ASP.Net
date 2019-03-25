using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonLib
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string streetOne;
        private string streetTwo;
        private string city;
        private string zipCode;
        private string state;
        private string email;
        private string phone;

        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
        public string LastName { get { return this.lastName; } set { this.lastName = value; } }
        public string StreetOne { get { return this.streetOne; } set { this.streetOne = value; } }
        public string StreetTwo { get { return this.streetTwo; } set { this.streetTwo = value; } }
        public string City { get { return this.city; } set { this.city = value; } }
        public string ZipCode { get { return this.zipCode; } set { this.zipCode = value; } }
        public string State { get { return this.state; } set { this.state = value; } }
        public string Email { get { return this.email; } set { this.email = value; } }
        public string Phone { get { return this.phone; } set { this.phone = value; } }

        public Boolean ValidLogin(String user, String pass)
        {
            if (user == "NEIT" && pass == "Password")
                return true;
            else
                return false;
        }
    }
}