using DesignPatternsDemo.BusinessManagers;
using DesignPatternsDemo.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoEntities context = new DemoEntities();
            Employee e = new Employee();

            Console.Write("Enter Employee Name : ");
            e.EmployeeName = Console.ReadLine();

            Console.Write("Enter Department : ");
            e.Department = Console.ReadLine();

            Console.Write("Employement Type\n1. Permanent\n2. Contract\nEnter Employment Type : ");
            e.EmployeeTypeId = Convert.ToInt32(Console.ReadLine());

            EmployeeManagerFactory factory = new EmployeeManagerFactory();
            IEmployeeManager manager = factory.GetEmployeeManager(e.EmployeeTypeId.Value);

            e.HourlyPay = manager.GetHourlyPay();
            e.BonusRate = manager.GetBonusRate();

            context.Employees.Add(e);
            context.SaveChanges();

            foreach(var emp in context.Employees)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}", emp.EmployeeId, emp.EmployeeName, emp.Department, emp.EmployeeTypeId, emp.EmployeeType.EmployeeType1, emp.HourlyPay, emp.BonusRate);
            }
        }
    }
}