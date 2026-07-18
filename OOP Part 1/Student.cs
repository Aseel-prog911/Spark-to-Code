using System;

namespace OOP_Part_1
{
    internal class Student
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Student(string studentID, string name, string address)
        {
            StudentID = studentID;
            Name = name;
            Address = address;
        }

        public void UpdateAddress(string newAddress)
        {
            Address = newAddress;
            Console.WriteLine("Address updated successfully.");
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine("Student ID: " + StudentID);
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Address: " + Address);
        }
    }
}