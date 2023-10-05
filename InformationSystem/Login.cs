using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    internal class Login
    {
        public object LoginIntoSystem(string username, string password, List<Student>? students, List<Teacher>? teachers)
        {
            foreach (Student student in students)
            {
                if(student.username.Equals(username) && student.password.Equals(password))
                {
                    return student;
                }
            }
            foreach (Teacher teacher in teachers)
            {
                if (teacher.username.Equals(username) && teacher.password.Equals(password))
                {
                    return teacher;
                }
            }
            return null;
        }
    }
}
