using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGradeTracker
{
    class Principal : Member, IPayee
    {
        public void pay()
        {
            Console.WriteLine("Paying Principal.");
        }
    }
}
