using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadStudentInfo();
        }

        private void LoadStudentInfo()
        {
            Student student = new Student();
            foreach (Student s in student.GetStudents())
            {
                dataGridView1.Rows.Add(s.StudentID, s.LastName, 
                    s.FirstName, s.MiddleName, s.CourseCode);
            }
        }
    }
}
