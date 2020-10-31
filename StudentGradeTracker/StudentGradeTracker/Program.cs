using System;
using System.Collections.Generic;

namespace StudentGradeTracker
{
    enum School
    {
        MIT,
        Harvard,
        Standford,
        UAT,
    }
    class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            Logger.Log("Tracker started", priority: 0);

            Payroll payroll = new Payroll();
            payroll.payAll();

            var adding = true;

            //Questions
            while (adding)
            {
                try
                {
                    Logger.Log("Adding new student");

                    var newStudent = new Student();

                    newStudent.Name = Util.Console.Ask("Student Name: ");

                    newStudent.Grade = Util.Console.AskInt("Student Grade: ");

                    newStudent.School = (School)Util.Console.AskInt("School Name (Type corresponding number): \n 0: MIT \n 1: Harvard \n 3: Stanford \n 4: UAT");

                    newStudent.Birthday = Util.Console.Ask("Student Birthday: ");

                    newStudent.Address = Util.Console.Ask("Student Address: ");

                    newStudent.Phone = Util.Console.AskInt("Student Phone: ");

                    students.Add(newStudent);
                    Student.Count++;
                    Console.WriteLine("Student Count: {0}", Student.Count);

                    //To add another student
                    Console.WriteLine("Add Another? y/n");

                    if (Console.ReadLine() != "y")
                        adding = false;
                }
                catch (FormatException msg)
                {
                    Console.WriteLine(msg.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error adding student, Please try again.");
                }
            }

            ShowGrade("");

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            }
            Exports();

        }
        //For Importing Students
        static void Import()
        {
            var importedStudent = new Student("Jenny", 86, "birthday", "address", 123456);
            Console.WriteLine(importedStudent.Name);
        }

        static void Exports()
        {
            foreach (var student in students)
            {
                switch (student.School)
                {
                    case School.MIT:
                        Console.WriteLine("Exporting to MIT");
                        break;
                    case School.Harvard:
                        Console.WriteLine("Exporting to Harvard");
                        break;
                    case School.Standford:
                        Console.WriteLine("Exporting to Stanford");
                        break;
                }
            }
        }

        static void ShowGrade(string name)
        {
            var found = students.Find(student => student.Name == name );

            Console.WriteLine("{0}'s Grade: {1}", found.Name, found.Grade);
        }
    }
    //School Member (Teachers + students)
    class Member
    {
        public string Name { get; set; }

        public string Address { get; set; }
        public int phone { get; set; }

        public int Phone
        {
            set { phone = value; }
        }
    }

    //Student Information
    class Student : Member
    {
        static public int Count { get; set; } = 0;

        public int Grade { get; set; }
        public string Birthday { get; set; }
        public School School { get; set; }

        public Student()
        {

        }

        public Student(string name, int grade, string birthday, string address, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }
    }
}