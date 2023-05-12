using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLibrary
{
    public interface IStudetService
    {
        public List<Student> GetStudents();
    }
}
