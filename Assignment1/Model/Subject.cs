using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Assignment1.Model
{
    internal class Subject
    {
        // define constants
        const string DEF_SUBJECT_CODE = "Unknown";
        const string DEF_SUBJECT_NAME = "Unknown";
        const double DEF_COST = 0.00;

        // define variables
        private string subjectCode;
        private string subjectName;
        private double cost;

        // Property Assessor Methods
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public double SubjectCost { get; set; }

        // no arg constructor
        public Subject() : this(DEF_SUBJECT_CODE, DEF_SUBJECT_NAME, DEF_COST)
        {

        }

        // all arg constructor
        public Subject(string subjectCode, string subjectName, double cost)
        {
            this.SubjectCode = subjectCode;
            this.SubjectName = subjectName;
            this.SubjectCost = cost;
        }

        // ToString for outputting the Subject details
        public override string ToString()
        {
            return " subjectCode:" + SubjectCode + " subjectName:" + SubjectName + " cost:" + SubjectCost;
        }
    }
}
