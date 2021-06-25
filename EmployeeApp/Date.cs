using System;
namespace EmployeeApp
{
    internal class Date
    {
        private byte day;
        private byte month;
        private int year;

        public Date(byte day, byte month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public void ShowDate()
        {
            Console.WriteLine("{0}/{1}/{2}", day, month, year);
            
        }

    }
}