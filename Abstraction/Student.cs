using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Student: StudentInfo
    {
        public int StudentID {  get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public Student(int studentID, string lastName, string firstName, string middleName, string courseCode)
        {
            StudentID = studentID;
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            CourseCode = courseCode;
        }

        public Student() { }

        public override List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1,"VALENTIN","REXCIES","ANTONIO","BSIT"));
            return students;
        }
    }
}
