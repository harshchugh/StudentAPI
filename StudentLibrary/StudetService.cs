using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLibrary
{
    public class StudetService : IStudetService
    {
        public List<Student> GetStudents()
        {
            var students = new List<Student>() { 
                new Student {Name="Alice", Age=20, Hobbies = new string[] {"reading", "swimming", "coding"} },
                new Student {Name="Alice", Age=22, Hobbies = new string[]{"painting", "dancing", "singing" } }
            };

            return students;
        }
    }
}
