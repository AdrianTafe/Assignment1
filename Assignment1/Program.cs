using Assignment1;

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
Address personAddress = new Address(12, "Lovely Street", "Adelaide", "5000", "SA");
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

// testing new student with enrollment and subject
Student myStudent3 = new Student(333000, "Diploma in Music", "1/09/2026", "Adrian", "adrian@bobsmail.au", "0444 040 040", myEnrollment);
Console.WriteLine(myStudent3);

// testing no arg constructors
Student myStudent4 = new Student();
Console.WriteLine(myStudent4);