/*Create a console application that stores and displays multiple employees information of Alex Inc. Class Library: Contains Employee class. Console Application: Consumes the Employee class and creates multiple objects of Employee class.
 
 Step 1: Create a class library and console application. Add reference of class library into console application.

Step 2: Create a class called Employee in the class library with fields EmpID, EmpName, SalaryPerHour, NoOfWorkingHours and NetSalary. Additionally, add the following fields:

    - A static field called OrganizationName. It should be initialized as "Alexa Inc." in Main method.

    - A constant field called TypeOfEmployee and initialize it as "Contract Based" along with declaration.

    - A readonly field called DepartmentName and initialize it as "Finance Department" in constructor.

Step 3: Create an object of Employee class in the console application. Read each employee details (EmpID, EmpName, SalaryPerHour, NoOfWorkingHours) from the user (from the keyboard) using loop.

Calculate net salary (SalaryPerHour * NoOfWorkingHours).

And display the all details of the same object (including EmpID, EmpName, SalaryPerHour, NoOfWorkingHours, NetSalary, OrganizationName, TypeOfEmployee, DepartmentName) and then ask the user 'Do you want to continue to next employee'.

If the user choose 'Yes', proceed to the next employee; otherwise stop the loop.*/

using System;
using ClassLibraryEmp;

namespace EmployeeDataBase.NETFr
{
    internal class Program
    {
        static void Main()
        {
            //Create object of employee class
            Employee emp = new Employee();
            //read details of max. 100 employees
            for (int i = 1;i<=100;i++)
            {   
                Console.WriteLine("Employee number:"+i);
                Console.WriteLine("Please input Employee ID: ");
                emp.EmpID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please input Employee Name: ");
                emp.EmpName = Console.ReadLine();
                Console.WriteLine("Please input Employee Salary per hour: ");
                emp.SalaryPerHour= Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please input Employee No of working hours: ");
                emp.NoOfWorkingHours = Convert.ToDouble(Console.ReadLine());

                emp.NetSalary = emp.SalaryPerHour * emp.NoOfWorkingHours;

                Console.WriteLine("Values added successfully.\nEmployee:"+i);

                Console.WriteLine("EmpID: "+emp.EmpID);
                Console.WriteLine("EmpName: "+emp.EmpName);
                Console.WriteLine("SalarPerHour: "+emp.SalaryPerHour);
                Console.WriteLine("NoOfWorkingHours: "+emp.NoOfWorkingHours);
                Console.WriteLine("NetSalary: "+emp.NetSalary);
                Console.WriteLine("OrganizationName: " + Employee.OrganizationName);
                Console.WriteLine("TypeOfEmployee: " + Employee.TypeOfEmployee);
                Console.WriteLine("DepartmentName: " + emp.DepartmentName);

                questionstart:
                Console.WriteLine("Do you wish to continue to the next employee?\n1 = Yes \n2 = No");
                int response = Convert.ToInt32(Console.ReadLine());
                if (response ==1)
                { continue;}

                else if (response == 2)
                { break;}
                else 
                { 
                    Console.WriteLine("Wrong value answer detected. Please try again."); 
                    goto questionstart; 
                }
            }
        }
    }
}
