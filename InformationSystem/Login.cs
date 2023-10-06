using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    /// <summary>
    /// Before connect to system, student or teacher have to login
    /// </summary>
    internal class Login
    {
        /// <summary>
        /// Before to connect with information system, student or teacher have to login to system
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="students"></param>
        /// <param name="teachers"></param>
        /// <returns></returns>
        public object LoginIntoSystem(string username, string password, List<IStudent>? students, List<Teacher>? teachers)
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
