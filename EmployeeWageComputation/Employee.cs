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

        // private variables declared
        private string _company;
        private int _empRatePrHr;
        private int _numOfWrkngDays;
        private int _maxHoursPrMonth;
        private int _totalEmpWage;

        /// <summary>
        /// create a class constructor for the EmployeeWage class
        /// </summary>
        /// <param name="company"></param>
        /// <param name="empRatePrHr"></param>
        /// <param name="numOfWrkngDays"></param>
        /// <param name="maxHoursPrMonth"></param>
        public EmployeeWage(string company, int empRatePrHr, int numOfWrkngDays, int maxHoursPrMonth)
        {
            this._company = company;
            this._empRatePrHr = empRatePrHr;
            this._numOfWrkngDays = numOfWrkngDays;
            this._maxHoursPrMonth = maxHoursPrMonth;
        }

        /// <summary>
        /// method to calculate Wage
        /// </summary>
        public void WageCalculation() 
        {
            // variables
            int empHours = 0, totalEmpHours = 0, totalWorkingDays = 0;

            while ( empHours <= this._maxHoursPrMonth && totalWorkingDays < this._numOfWrkngDays )
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_FULL_Time:
                        empHours = 8;
                        break;

                    case IS_PART_TIME:
                        empHours = 4;
                        break;

                    default:
                        empHours = 0;
                        break;
                }
                totalEmpHours += empHours;
                Console.WriteLine("Day Number : " + totalWorkingDays + " Employee Hours : " + empHours); ;
            }
            this._totalEmpWage = totalEmpHours * this._empRatePrHr;
            Console.WriteLine("Total Employee Wage for company " + this._company + " is " + this._totalEmpWage);
        }
        
        public string toString()
        {
            return "Total Employee Wage for company " + this._company + " is " + this._totalEmpWage;
        }
    }        
}
