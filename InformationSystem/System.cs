using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    internal class System
    {
        public List<Student> students { get; private set; }
        public List<Teacher> teachers { get; private set; }
        private Administrator admin { get; init; }
        private Login login { get; init; }
        public System(Administrator admin, Login login)
        {
            students = new List<Student>();
            teachers = new List<Teacher>();
            this.login = login;
            this.admin = admin;
        }
        public void LoginIntoSystem(string username, string password)
        {
            object signIn = login.LoginIntoSystem(username, password, students, teachers);
            if(signIn is Student)
            {
                Console.WriteLine(@"You can choose between:
1 - Schedule 
2 - School grades
3 - Homework");
            manipulationSystem();
            }
            if(signIn is Teacher)
            {
                Console.WriteLine(@"You can choose between:
1 - Schedule 
2 - Students school grades
3 - new homework");
            }
        }
        private void manipulationSystem()
        {

        }
    }
}
