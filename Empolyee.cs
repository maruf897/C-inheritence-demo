using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp
{
    internal class Empolyee
    {
        private string id;
        private string name; 
        private Date dateOfBirth;
        private Date joiningDate;
        private string bloodGroup;
        private Address address;
        private int monthlySalary;
        private string phoneNo;

       

       internal Empolyee(string id, string name, Date dateOfBirth, Date joiningDate, string bloodGroup, Address address, int monthlySalary, string phoneNo)
        {
            this.id = "E-"+id;
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.joiningDate = joiningDate;
            this.bloodGroup = bloodGroup;
            this.address = address;
            this.MonthlySalary = monthlySalary;
            this.phoneNo = phoneNo;
        }

        public int MonthlySalary { get => monthlySalary; set => monthlySalary = value; }

        internal virtual void  ShowInfo()
        {
            Console.WriteLine("Id: {0}", id);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Date of Birth: ");
            dateOfBirth.ShowDate();
            Console.WriteLine("Joining Date: ");
            joiningDate.ShowDate();
            Console.WriteLine("Blood Group: {0}", bloodGroup);
            Console.WriteLine("Address: ");
            address.ShowAddress();
            Console.WriteLine("Salary: {0}", MonthlySalary);
            Console.WriteLine("Phone Number: {0}", phoneNo);
        }
        internal virtual void ShowTotalIncome() { }
    }
}
