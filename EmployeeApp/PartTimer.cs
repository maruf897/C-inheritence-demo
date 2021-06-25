using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp
{
    internal class PartTimer: Empolyee
    {
        internal PartTimer(string id, string name, Date dateOfBirth, Date joiningDate, string bloodGroup, Address address, int monthlySalary, string phoneNo) : base(id, name, dateOfBirth, joiningDate, bloodGroup, address, monthlySalary, phoneNo)
        {
            
        }
        internal override void ShowInfo()
        {
            Console.WriteLine("Part Timer:");
            base.ShowInfo();
            
        }

        internal override void ShowTotalIncome()
        {
            Console.WriteLine("Total Income: {0}", this.MonthlySalary );
        }
    }
}
