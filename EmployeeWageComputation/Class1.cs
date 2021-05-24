using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    public class Employee
    {
        int isPresent = 1;

        public void attendence() 
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == isPresent)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");

        }

    }
}
