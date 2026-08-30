using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class Person
    {
        // Define constants
        public const string DEF_NAME = "Unknown";
        public const string DEF_EMAIL = "Unknown";
        public const string DEF_PHONE_NUMBER = "Unknown";

        // Address class for Person
        private Address address;

        // Property Assessor Method for name
        public string PersonName { get; set; }
        // Property Assessor Method for email
        public string PersonEmail { get; set; }
        // Property Assessor Method for phone number
        public string PersonPhoneNumber { get; set; }
        // Property Assessor Method for address
        public Address PersonAddress { get; set; }

        // No arg constructor
        public Person() : this(DEF_NAME, DEF_EMAIL, DEF_PHONE_NUMBER)
        {

        }

        // all arg constructor
        public Person(string name, string email, string phoneNumber) : this(name, email, phoneNumber, new Address())
        {

        }

        public Person(string name, string email, string phoneNumber, Address address)
        {
            PersonName = name;
            PersonEmail = email;
            PersonPhoneNumber = phoneNumber;
            PersonAddress = address;
        }

        // setup ToString for output of Person details
        public override string ToString()
        {
            return base.ToString() + " name:" + PersonName + " email:" + PersonEmail + " phoneNumber:" + PersonPhoneNumber + " address:" + PersonAddress;
        }

        // equals method
        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;

            if (ReferenceEquals(obj, this))
                return true;

            if (obj.GetType() != GetType())
                return false;

            Person person = (Person)obj;
            return person.PersonName == this.PersonName && person.PersonEmail == this.PersonEmail && person.PersonPhoneNumber == this.PersonPhoneNumber;
        }

        public static bool Equals(object obj1, object obj2)
        {
            if (obj1 == obj2)
                return true;
            if (obj1 == null || obj2 == null)
                return false;
            else return obj1.Equals(obj2);
        }
    }
}
