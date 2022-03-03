using System;

namespace SalaryCalculator
{
    public class EmployeeService
    {
        private const decimal BASIC_SALARY = 10000000;

        public static decimal CalculateSalary(EmployeeType employeeType, int years)
        {
            if (years < 0)
            {
                throw new ArgumentException("Years of experience is not valid");
            }

            decimal factor = 0;
          
            switch(EmployeeType){
                case EmployeeType.Engineer:
                    factor = 1;
                    break;
                case EmployeeType.SeniorEngineer:
                case EmployeeType.Manager:
                    factor = 1.5;
                    break;
                case EmployeeType.SeniorManager:
                case EmployeeType.Expert:
                    factor = 3;
                    break;

            var salary = BASIC_SALARY * years * factor;

            return salary;
        }
    }
}
