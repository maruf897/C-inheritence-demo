using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp
{
    internal class MarketAnalyst: Empolyee
    {
        private int commission; 
        internal MarketAnalyst(string id, string name, Date dateOfBirth, Date joiningDate, string bloodGroup, Address address, int monthlySalary, string phoneNo, int commission) : base(id, name, dateOfBirth, joiningDate, bloodGroup, address, monthlySalary, phoneNo)
        {
            this.commission = commission;
        }
        internal override void ShowInfo()
        {
            Console.WriteLine("Market Analyst");
            base.ShowInfo();
            Console.WriteLine("Commission: {0}", commission);
        }

        internal override void ShowTotalIncome()
        {
            Console.WriteLine("Total Income: {0}", this.MonthlySalary + commission);
        }
    }
}
