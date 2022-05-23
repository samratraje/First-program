using System;
using System.Collections;

namespace CS_OOPs_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeDTO emp = new EmployeeDTO();
            EmployeeLogic logic = new EmployeeLogic();
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("ENter EMployee Information as EmpNo, EmpName, Salary, Designation, DeptNAme in this order only");
                // Set values for propertes
                emp.EmpNo = Convert.ToInt32(Console.ReadLine());
                emp.EmpName = Console.ReadLine();
                emp.Salary = Convert.ToInt32(Console.ReadLine());
                emp.Designation = Console.ReadLine();
                emp.DeptName = Console.ReadLine();

                // Un-Necessary Hard Coding (Remove it)
                //if (emp.DeptName != "IT" || emp.DeptName != "HR" || emp.DeptName != "TR")
                //{
                //    Console.WriteLine("Sorry DeptName is Not acceptable");
                //    return;
                //}
                // pass data to the AddEmployee() method of Logic class
                logic.AddEmployee(emp);
            }

                ArrayList emps = logic.GetEmployees();
                Console.WriteLine($"EmpNo \t EmpName \t Salary \t Designation \t DeptName");
                foreach (EmployeeDTO item in emps)
                {
                    //Console.WriteLine($"{item.EmpNo}\t{item.EmpName}\t{item.Salary}\t{item.Designation}\t{item.DeptName} ");

                    Logger.Log(emp); // The static method

                    Console.WriteLine( "Which employee you want to see income" );
                    Console.ReadLine();
                    Console.WriteLine("Please press any key to calculate payroll");
                    Console.ReadLine();
                    if (emp.Designation == "Director")
                    {
                        DirectorPayroll director = new DirectorPayroll();
                        int income = director.CalculateIncome(emp);
                        double tax = director.CalculateTax(income);
                        Console.WriteLine($"Income of Director = {income} and payable tax is {tax}");
                    }
                    if (emp.Designation == "Manager")
                    {
                        ManagerPayroll manager = new ManagerPayroll();
                        int income = manager.CalculateIncome(emp);
                        double tax = manager.CalculateTax(income);
                        Console.WriteLine($"Income of Manager = {income} and payable tax is {tax}");
                    }
                    if (emp.Designation == "Developer")
                    {
                        DeveloperPayroll Developer = new DeveloperPayroll();
                        int income = Developer.CalculateIncome(emp);
                        double tax = Developer.CalculateTax(netsalary: income);
                        Console.WriteLine($"Income of Developer = {income} and payable tax is {tax}");
                    }
                    if (emp.Designation == "Engineer")
                    {
                        EngineerPayroll Engineer = new EngineerPayroll();
                        int income = Engineer.CalculateIncome(emp);
                        double tax = Engineer.CalculateTax(income);
                        Console.WriteLine($"Income of Engineer = {income} and payable tax is {tax}");
                    }
                

            }


            Console.WriteLine("Employee Infromation System");
            Console.ReadLine();
        }
    }
}
