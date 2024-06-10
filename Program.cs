using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Date dob = new Date(18, 05, 1997);
            Date jd = new Date(18, 05, 2020);
            Address ad = new Address("Rupganj", "Narayanganj");
            Empolyee e1 = new ItExecutive("0011","al azad",dob,jd,"B+",ad,50000,"0565460",1200);
            e1.ShowInfo();
            e1.ShowTotalIncome();
            Empolyee e2 = new HrManager("0012", "wasek", dob, jd, "A+", ad, 60000, "0554540", 1200);
            e2.ShowInfo();
            e2.ShowTotalIncome();
            Date dob2 = new Date(25, 05, 1995);
            Date jd2 = new Date(18, 12, 2020);
            Address ad2 = new Address("Uttara", "Dhaka");
            Empolyee e3 = new MarketAnalyst("0013", "noyon", dob2, jd2, "B+", ad2, 50000, "0565460", 1200);
            e3.ShowInfo();
            e3.ShowTotalIncome();
            Empolyee e4 = new PartTimer("0014", "ayon", dob2, jd2, "A+", ad2, 60000, "0554540");
            e4.ShowInfo();
            e4.ShowTotalIncome();
        }
       
    }
}
