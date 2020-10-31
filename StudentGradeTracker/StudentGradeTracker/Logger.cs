using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGradeTracker
{
    class Logger
    {
        const string DefaultSystemName = "SystemTracker";
        public static void Log(string msg, string system = DefaultSystemName, int priority = 1)
        {
            Console.WriteLine("system: {0}, Priority {1}, Msg: {2}", system, priority, msg);
        }
    }
}
