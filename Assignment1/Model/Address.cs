using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1.Model
{
    internal class Address
    {
        // Define constants
        const string DEF_STREET_NUM = "Unknown";
        const string DEF_STREET_NAME = "Unknown";
        const string DEF_SUBURB = "Unknown";
        const string DEF_POSTCODE = "Unknown";
        const string DEF_STATE = "Unknown";

        // Define variables
        private string streetNum;
        private string streetName;
        private string suburb;
        private string postcode;
        private string state;

        // Property Assessor Methods
        public string StreetNum { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }

        // no arg constructor
        public Address() : this(DEF_STREET_NUM, DEF_STREET_NAME, DEF_SUBURB, DEF_POSTCODE, DEF_STATE)
        {

        }

        // all arg constructor
        public Address(string streetNum, string streetName, string suburb, string postcode, string state)
        {
            StreetNum = streetNum;
            StreetName = streetName;
            Suburb = suburb;
            Postcode = postcode;
            State = state;
        }

        // ToString for output of Address details
        public override string ToString()
        {
            return " streetNum:" + StreetNum + " streetName:" + StreetName + " suburb:" + Suburb + " postcode:" + Postcode + " state:" + State;
        }
    }
}
