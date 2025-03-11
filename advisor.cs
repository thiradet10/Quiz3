using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3
{
    public class Advisor : Person
    {
        public List<Student> Students { get; set; }

        public Advisor(string name, string major) : base(name, major)
        {
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }
}
