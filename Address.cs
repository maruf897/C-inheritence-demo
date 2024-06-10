using System;
namespace EmployeeApp
{
    internal class Address
    {
        private string thana;
        private string district; 
       

        public Address(string thana, string district)
        {
            this.thana = thana;
            this.district = district;
           
        }
        public void ShowAddress()
        {
            Console.WriteLine("Thana: {0}, District: {1}", thana, district);
        }
    }
}