using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    internal class SystemInformation
    {
        public List<Student> students { get; private set; }
        public List<Teacher> teachers { get; private set; }
        private Administrator admin { get; init; }
        private Login login { get; init; }
        public SystemInformation(Administrator admin, Login login)
        {
            students = new List<Student>();
            teachers = new List<Teacher>();
            this.login = login;
            this.admin = admin;
        }
        public void LoginIntoSystem(string username, string password)
        {
            string choice = "";
            object signIn = login.LoginIntoSystem(username, password, students, teachers);
            if(signIn is Student)
            {
                do
                {
                    Student student = (Student)signIn;
                    Console.WriteLine(@"You can choose between:
    1 - Schedule 
    2 - School grades
    3 - Homework
    4 - Logout");
                    choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            if (student.schedule is null)
                            {
                                student.AddSchedule(new Schedule());
                                Console.WriteLine(student.schedule);
                            }
                            else
                                Console.WriteLine(student.schedule);
                            break;
                        case "2":
                            Console.WriteLine(student.grades);
                            break;
                        case "3":
                            Console.WriteLine(student.homework);
                            break;
                    }
                } while (choice != "4");
            }
            if(signIn is Teacher)
            {
                Teacher teacher = (Teacher)signIn;
                Console.WriteLine(@"You can choose between:
1 - Schedule 
2 - Students school grades
3 - new homework");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        if (teacher.schedule is null)
                        {
                            teacher.AddSchedule(new Schedule());
                            Console.WriteLine(teacher.schedule);
                        }
                        else
                            Console.WriteLine(teacher.schedule);
                        break;
                    case "2":
                        Console.WriteLine("Name student");
                        string nameStudent = Console.ReadLine();
                        Console.WriteLine("Grade: ");
                        string grade = Console.ReadLine();
                        foreach (Student student in students)
                        {
                            if (student.name.Equals(nameStudent))
                                student.AddGrade(grade);
                        }
                        break;
                    case "3":
                        Console.WriteLine("Name homework");
                        string homework = Console.ReadLine();
                        foreach (Student student in students)
                        {
                            student.AddHomework(homework);
                        }                 
                        break;
                }
            }
        }
        private Schedule NewSchedule()
        {
            return new Schedule();
        }
        public void AddStudent(string name, string surname, Student.Titles titles, string username, string password)
        {
            students.Add(new Student(name, surname, titles, username, password));
        }
        public void AddTeacher(string name, string surname, Student.Titles titles, string username, string password)
        {
            teachers.Add(new Teacher(name, surname, titles, username, password));
        }
    }
}
