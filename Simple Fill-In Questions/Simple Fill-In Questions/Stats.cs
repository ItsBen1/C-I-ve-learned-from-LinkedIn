using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Fill_In_Questions
{
    class Stats
    {
        public void Start()
        {
            Program.Posted += HasPosted;
        }

        void HasPosted()
        {
            Console.WriteLine("Survey Posted, Run Stats.");
        }
    }
}
