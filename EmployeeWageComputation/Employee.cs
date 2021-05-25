using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    public class Employee
    {
        const int isFullTime = 1;
        const int isPartTime = 2;
        public int empRatePerHour = 20;
        public int empHour = 0;
        
        public void Attendence() 
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == isFullTime)
            {
                empHour = 8;
            }
            else if (empCheck == isPartTime)
            {
                empHour = 4;
            }
            else
            {
                empHour = 0;
            }
            int dailyWage = empHour * empRatePerHour;
            Console.WriteLine(dailyWage);
        }
    }
}
