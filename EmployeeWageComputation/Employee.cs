using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    public class EmployeeWrkHr
    {
        //Constants
        public const int IS_FULL_Time = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int WORKING_DAYS_PER_MNTH = 20;
        public const int TOTAL_WORKING_HR = 100;

        //Variables
        public int empHour = 0;
        public int workingDays = 0;
        public int totalWorkingHours = 0;

        // Method to calculate total working hours
        public void WorkHour() 
        {
            while ( empHour <= TOTAL_WORKING_HR && workingDays < WORKING_DAYS_PER_MNTH )
            {
                workingDays++;
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
        }
    }

    // Wage class inherits EmployeeWrkHr class
    public class Wage : EmployeeWrkHr
    {
        // Method to calculate salary
        public void Salary()
        {
            WorkHour();
            int salary = totalWorkingHours * EMP_RATE_PER_HR;
            Console.WriteLine("Wage of employee : " + salary);
        }                            
    }
}
