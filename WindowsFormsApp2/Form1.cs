using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LoadEmployeeInfo();

            LoadDepartmentInfo();

        }

        private void LoadEmployeeInfo()
        {
            Employee employee = new Employee();
            foreach (Employee e in employee.GetEmployees())
            {
                dataGridView1.Rows.Add(e.EmployeeID, e.EmployeeName, e.Position, e.DepartmentCode, e.Salary);
            }

        }

        private void LoadDepartmentInfo()
        {
            Department department = new Department();
            foreach (Department d in department.GetDepartments())
            {
                dataGridView3.Rows.Add(d.DepartmentCode, d.DepartmentDescription);
            }
        }

    


    }
}
