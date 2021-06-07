using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            EmployeeWage mseb = new EmployeeWage("MSEB", 50, 20, 100);
            EmployeeWage google = new EmployeeWage("Google", 100, 20, 100);

            mseb.WageCalculation();
            Console.WriteLine(mseb.toString());

            google.WageCalculation();
            Console.WriteLine(google.toString());            
        }
    }
}
