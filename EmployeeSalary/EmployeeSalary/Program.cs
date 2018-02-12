using System;

namespace EmployeeSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            HR emp_hr = new HR();
            emp_hr.experience = 4;
            emp_hr.basic_salary = 8000;
            emp_hr.annual_salary = emp_hr.basic_salary * 12 + emp_hr.experience * HR.bonus;
            Console.WriteLine("HR's annual salary is Rs." + emp_hr.annual_salary);

            Developer emp_dev = new Developer();
            emp_dev.experience = 5;
            emp_dev.basic_salary = 8000;
            emp_dev.annual_salary = emp_dev.basic_salary * 12 + emp_dev.experience * Developer.bonus;
            Console.WriteLine("Developer's annual salary is Rs." + emp_dev.annual_salary);

        }
    }
    abstract class Employee
    {
        public string id;
        public string name;
        public string designation;
        public double experience;
        public double annual_salary;
        public string joining_date;
        abstract public double salary_calculate();
    }
    class HR : Employee
    {
        public static double bonus = 1000;
        public double basic_salary;
        public override double salary_calculate()
        {
            return bonus * experience;
        }
    }
    class Developer : Employee
    {
        public static double bonus = 2000;
        public double basic_salary;
        public override double salary_calculate()
        {
            return bonus * experience;
        }
    }
}
