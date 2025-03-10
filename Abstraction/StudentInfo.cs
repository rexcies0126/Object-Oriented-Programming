using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class StudentInfo: Course
    {
        public abstract List<Student> GetStudents();

    }
}
