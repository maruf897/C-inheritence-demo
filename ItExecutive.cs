using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp
{
    internal class ItExecutive: Empolyee
    {
        private int projectBonus;

        internal ItExecutive(string id, string name, Date dateOfBirth, Date joiningDate, string bloodGroup, Address address, int monthlySalary, string phoneNo,int projectBonus):base(id, name,dateOfBirth,joiningDate,bloodGroup, address, monthlySalary, phoneNo)
        {
            this.projectBonus = projectBonus;
        }

        internal override void ShowInfo()
        {
            Console.WriteLine("It Executive");
            base.ShowInfo();
            Console.WriteLine("Project Bonus: {0}", projectBonus);
        }

        internal override void ShowTotalIncome()
        {
            Console.WriteLine("Total Income: {0}", this.MonthlySalary+projectBonus);
        }
    }
}
