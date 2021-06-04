using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        //Constants
        public const int IS_FULL_Time = 1;
        public const int IS_PART_TIME = 2;        

        //Variables
        public int empHour = 0;
        public int totalWorkingDays = 0;
        public int totalWorkingHours = 0;
        
        /// <summary>
        /// Method  to calculate salary
        /// </summary>
        /// <param name="company"></param>
        /// <param name="empRatePerHour"></param>
        /// <param name="workingDaysPerMonth"></param>
        /// <param name="workingHourPerMonth"></param>
        public void WageCalculation(string company, int empRatePerHour, int workingDaysPerMonth, int workingHourPerMonth) 
        {
            while ( empHour <= workingHourPerMonth && totalWorkingDays < workingDaysPerMonth )
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_FULL_Time:
                        empHour = 8;
                        break;

                    case IS_PART_TIME:
                        empHour = 4;
                        break;

                    default:
                        empHour = 0;
                        break;
                }
                totalWorkingHours += empHour;                
            }
            int salary = totalWorkingHours * empRatePerHour;
            Console.WriteLine("company : " + company + ", Salary : " + salary);
        }
    }        
}
