using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp
{
    internal class HrManager: Empolyee
    {
        private int KPI;

        internal HrManager(string id, string name, Date dateOfBirth, Date joiningDate, string bloodGroup, Address address, int monthlySalary, string phoneNo, int kpi) : base(id, name, dateOfBirth, joiningDate, bloodGroup, address, monthlySalary, phoneNo)
        {
            this.KPI = kpi;
        }
        internal override void ShowInfo()
        {
            Console.WriteLine("Hr Manager");
            base.ShowInfo();
            Console.WriteLine("KPI: {0}", KPI);
        }

        internal override void ShowTotalIncome()
        {
            Console.WriteLine("Total Income: {0}", this.MonthlySalary + KPI);
        }
    }
}
