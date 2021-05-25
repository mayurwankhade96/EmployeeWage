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
        public int workingDaysPerMonth = 20;
        public int totalSalaryForMonth = 0;
        
        public void Attendence() 
        {
            for (int day = 1; day <= workingDaysPerMonth; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case isFullTime:
                        empHour = 8;
                        break;
                    case isPartTime:
                        empHour = 4;
                        break;
                    default:
                        empHour = 0;
                        break;
                }
                int dailyWage = empHour * empRatePerHour;
                totalSalaryForMonth= totalSalaryForMonth + dailyWage ;
            }
            Console.WriteLine(totalSalaryForMonth);
        }
    }
}
