using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3rdAssignment
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine(" Enter Employee Id :");
            employee.EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name : ");
            employee.EmpName = Console.ReadLine();
            Console.WriteLine("Enter  salary For Employee : ");
            employee.Salary = Convert.ToDouble(Console.ReadLine());
            employee.calculateSalary();
            Console.WriteLine("Gross Salary of Employee :" + employee.GrossSalary);
            Console.WriteLine("Net Salary of Employee :" + employee.NetSalary);


            Manager manager = new Manager();
            Console.WriteLine("Enter the id of manager: ");
            manager.EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name of manager: ");
            manager.EmpName = Console.ReadLine();
            Console.WriteLine("Enter the salary of manager: ");
            manager.Salary = Convert.ToDouble(Console.ReadLine());
            manager.calculateSalary();
            Console.WriteLine("Gross Salary of Manager :" + manager.GrossSalary);


            MarketingExecutive me = new MarketingExecutive();
            Console.WriteLine("Enter the Id of Marketing Executiveg : ");
            me.EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name of Marketing Executive: ");
            me.EmpName = Console.ReadLine();
            Console.WriteLine("Enter the salary of Marketing Executive: ");
            me.Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the kilometers of Marketing Executive: ");
            me.kilo = Convert.ToDouble(Console.ReadLine());
            me.calculateSalary();
            Console.WriteLine("Gross Salary of MarketingExecutive :" + me.GrossSalary);
            Console.ReadKey();

        }

    }
 }
