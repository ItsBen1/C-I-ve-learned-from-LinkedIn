using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGradeTracker
{

    interface IPayee
    {
        void pay();
    }

    class Payroll
    {
        List<IPayee> payees = new List<IPayee>();

        public Payroll()
        {
            payees.Add( new Teacher());
            payees.Add(new Teacher());
            payees.Add(new Principal());

            Logger.Log("PayRoll started", "PayRoll");
        }

        public void payAll()
        {
            foreach(var payee in payees)
            {
                payee.pay();
            }

            Logger.Log("PayAll Completed", "PayRoll", 2);
        }
    }
}
