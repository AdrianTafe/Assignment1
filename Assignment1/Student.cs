using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Assignment1
{
    sealed class Student: Person
    {
        // define constants
        const int DEF_STUDENT_ID = 0;
        const string DEF_PROGRAM = "Unknown";
        const string DEF_DATE_REGISTERED = "Unknown";

        private Enrollment enrollment;

        // Property Assessors
        public int StudentID { get; set; }
        public string StudentProgram { get; set; }
        public string StudentDateRegistered { get; set; }
        public Enrollment StudentEnrollment { get; set; }

        // no arg constructor
        public Student() : this(DEF_STUDENT_ID, DEF_PROGRAM, DEF_DATE_REGISTERED, DEF_NAME, DEF_EMAIL, DEF_PHONE_NUMBER)
        {

        }

        // all arg constructors
        public Student(int studentID, string program, string dateRegistered, string name, string email, string phoneNumber) : this(studentID, program, dateRegistered, name, email, phoneNumber, new Enrollment()) 
        {

        }

        public Student(int studentID, string program, string dateRegistered, string name, string email, string phoneNumber, Enrollment enrollment) : base(name, email, phoneNumber)
        {
            this.StudentID = studentID;
            this.StudentProgram = program;
            this.StudentDateRegistered = dateRegistered;
            this.StudentEnrollment = enrollment;
        }

        // ToString for output of Student details
        public override string ToString()
        {
            return base.ToString() + " studentID:" + StudentID + " program:" + StudentProgram + " dateRegistered:" + StudentDateRegistered + " enrollment:" + StudentEnrollment;
        }

        /// <summary>
        /// Method to hash the StudentID
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this.StudentID.GetHashCode();
        }

        /// <summary>
        /// Equals override method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (!base.Equals(obj)) return false;
            Student student = (Student)obj;
            return base.Equals(obj)
                && this.StudentID == student.StudentID 
                && this.StudentProgram == student.StudentProgram 
                && this.StudentDateRegistered == student.StudentDateRegistered;
        }

        /// <summary>
        /// Equals overload method
        /// </summary>
        /// <param name="student1"></param>
        /// <param name="student2"></param>
        /// <returns>Equality between student objects</returns>
        public static bool operator ==(Student student1, Student student2)
        {
            return object.Equals(student1, student2);
        }

        /// <summary>
        /// Does not equal overload method
        /// </summary>
        /// <param name="student1"></param>
        /// <param name="student2"></param>
        /// <returns>Does not equal between student objects</returns>
        public static bool operator !=(Student student1, Student student2)
        {
            return !object.Equals(student1, student2);
        }
    }
}
