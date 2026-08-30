using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class Enrollment
    {
        // define constants
        const string DEF_DATE_ENTROLLED = "Unknown";
        const string DEF_GRADE = "Unknown";
        const int DEF_SEMESTER = 0;

        private Subject subject;

        // Property Assessor Methods
        public string EnrollmentDateEnrolled { get; set; }
        public string EnrollmentGrade { get; set; }
        public int EnrollmentSemester { get; set; }
        public Subject EnrollmentSubject { get; set; }

        // no-arg constructor
        public Enrollment() : this(DEF_DATE_ENTROLLED, DEF_GRADE, DEF_SEMESTER)
        {

        }

        // all arg constructors
        public Enrollment(string dateEnrolled, string grade, int semester) : this(dateEnrolled, grade, semester, new Subject())
        {

        }

        public Enrollment(string dateEnrolled, string grade, int semester, Subject subject)
        {
            EnrollmentDateEnrolled = dateEnrolled;
            EnrollmentGrade = grade;
            EnrollmentSemester = semester;
            EnrollmentSubject = subject;
        }

        // ToString for output of Enrollment details
        public override string ToString()
        {
            return " dateEnrolled:" + EnrollmentDateEnrolled + " grade:" + EnrollmentGrade + " semester:" + EnrollmentSemester + " subject:" + EnrollmentSubject;
        }
    }
}
