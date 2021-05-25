using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    public class Employee
    {
        const int isPresent = 1;
        public int empHour = 8;
        public int empRatePerHour = 20;

        public void Attendence() 
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == isPresent)
            {
                int dailyWage = empHour * empRatePerHour;
                Console.WriteLine("Per day salary = " + dailyWage);
            }
            else
                Console.WriteLine("Per day salary = " + 0);
        }

    }
}
