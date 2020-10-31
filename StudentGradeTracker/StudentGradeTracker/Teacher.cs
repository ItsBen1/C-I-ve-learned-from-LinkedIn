using StudentGradeTracker;
using System;
using System.Collections.Generic;
using System.Text;

//Teacher Information
class Teacher : Member, IPayee
{
    public String Subject { get; set; }
    public void pay()
    {
        Console.WriteLine("Paying Teacher.");
    }
}
