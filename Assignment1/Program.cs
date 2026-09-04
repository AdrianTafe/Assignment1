using Assignment1.Model;

// create Person and test
Person myPerson = new Person();
myPerson.PersonName = "Bob";
myPerson.PersonEmail = "bob@bobsmail.au";
myPerson.PersonPhoneNumber = "0412 236 456";
Console.WriteLine(myPerson);

// test Person no arg constructor
Person myPerson3 = new Person();
Console.WriteLine(myPerson3);

// create Address amd testing
Address personAddress = new Address("12A", "Lovely Street", "Adelaide", "5000", "SA");
Person myPerson2 = new Person("Jason", "jason@bobsmail.au", "0412 421 412", personAddress);
Console.WriteLine(myPerson2);

// create Student amd testing
Student myStudent = new Student(012345, "Diploma in IT", "30/08/2026", "Gemma", "gemma@bobsmail.au", "0434 434 343");
Console.WriteLine(myStudent);

// equals testing amd testing
Student myStudent2 = new Student(012345, "Diploma in IT", "30/08/2026", "Gemma", "gemma@bobsmail.au", "0434 434 343");
Console.WriteLine("student1 == student2: " + (myStudent == myStudent2));
Console.WriteLine("student1.Equals(student2): " + myStudent.Equals(myStudent2));

// create subject
Subject mySubject = new Subject("F023SRI", "Study Really Intuitively", 1502.05);
Console.WriteLine(mySubject);

// create enrollment
Enrollment myEnrollment = new Enrollment("10/10/2025", "A+", 1, mySubject);
Console.WriteLine(myEnrollment);

// testing StudentID constructor
Student mystudent3 = new Student(465013);
Console.WriteLine(mystudent3);
mystudent3.StudentID = 210492;
Console.WriteLine(mystudent3.StudentID);
Console.WriteLine(mystudent3);

// testing new student with enrollment and subject
Address myAddress = new Address("44", "Random Street", "Melbourne", "3000", "VIC");
Student myStudent4 = new Student(333000, "Diploma in Music", "1/09/2026", "Adrian", "adrian@bobsmail.au", "0444 040 040", myEnrollment, myAddress);
Console.WriteLine(myStudent4);

// testing no arg constructors
Student myStudent5 = new Student();
Console.WriteLine(myStudent5);