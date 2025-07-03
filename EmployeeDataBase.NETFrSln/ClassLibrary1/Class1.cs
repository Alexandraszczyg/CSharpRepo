using System;


namespace ClassLibraryEmp
{
    public class Employee
    {
        public int EmpID;
        public string EmpName;
        public double SalaryPerHour;
        public double NoOfWorkingHours;
        public double NetSalary;
        public static string OrganizationName = "Alexa Inc.";
        public const string TypeOfEmployee = "Contract Based";
        public readonly string DepartmentName;

        // Constructor to initialize readonly field
        public Employee()
        {
            DepartmentName = "Finance Department";
        }


    }
}
