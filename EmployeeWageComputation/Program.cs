using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            EmployeeWage wage = new EmployeeWage();
            wage.WageCalculation("MSEB", 50, 20, 100);            
            wage.WageCalculation("Google", 100, 20, 100);
        }
    }
}
