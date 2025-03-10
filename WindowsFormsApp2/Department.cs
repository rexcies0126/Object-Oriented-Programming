using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Department
    {
        public string DepartmentCode { get; set; }
        public string DepartmentDescription { get; set; }

        public Department(string departmentCode, string departmentDescription)
        {
            this.DepartmentCode = departmentCode;
            this.DepartmentDescription = departmentDescription;
        }

        public Department(string departmentCode)
        {
            this.DepartmentCode = departmentCode;
        }

        public Department() { }


        public List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department("IT","IT DEPARTMENT"));
            departments.Add(new Department("AD", "ACCOUNTING DEPARTMENT"));
            return departments;
        }

    }
}
