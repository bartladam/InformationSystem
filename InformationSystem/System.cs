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
            string choice;
            object signIn = login.LoginIntoSystem(username, password, students, teachers);
            if(signIn is Student)
            {
                Student student = (Student)signIn;
                Console.WriteLine(@"You can choose between:
1 - Schedule 
2 - School grades
3 - Homework");
                choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        if (student.schedule is null)
                            student.AddSchedule(NewSchedule());
                        else
                            Console.WriteLine(student.schedule);
                        break;
                }
            }
            if(signIn is Teacher)
            {
                Console.WriteLine(@"You can choose between:
1 - Schedule 
2 - Students school grades
3 - new homework");
                choice = Console.ReadLine();
                switch (choice)
                {

                }
            }
        }
        private Schedule NewSchedule()
        {
            return new Schedule();
        }
    }
}
