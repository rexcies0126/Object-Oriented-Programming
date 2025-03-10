using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Employee: Department
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }

        public Employee(int employeeID, string employeeName, string position, string departmentCode, double salary): base(departmentCode)
        {
            this.EmployeeID = employeeID;
            this.EmployeeName = employeeName;
            this.Position = position;
            this.DepartmentCode = departmentCode;
            this.Salary = salary;
        }

        public Employee() { }

        //datasource
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(1, "REXCIES VALENTIN", "PROGRAMMER", "IT", 45000.75));
            return employees;
        }
    }
}
