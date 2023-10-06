using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    /// <summary>
    /// Place where are connecting teacher with students
    /// </summary>
    internal class SystemInformation
    {
        /// <summary>
        /// System have to know about students, because via system teachers have option to give them homeworks etc
        /// </summary>
        public List<IStudent> students { get; private set; }
        /// <summary>
        /// Teachers give students homework and grades via system
        /// </summary>
        public List<Teacher> teachers { get; private set; }
        /// <summary>
        /// System must have administrator, when system is broken
        /// </summary>
        private Administrator admin { get; init; }
        /// <summary>
        /// Via login student or teacher can connect with System
        /// </summary>
        private Login login { get; init; }
        public SystemInformation(Administrator admin, Login login)
        {
            students = new List<IStudent>();
            teachers = new List<Teacher>();
            this.login = login;
            this.admin = admin;
            this.admin.system = this;
        }
        /// <summary>
        /// When student or teacher login sucessfully, he/she can use system
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void LoginIntoSystem(string username, string password)
        {
            string choice = "";
            do
            {
                Console.Clear();
                if(login.LoginIntoSystem(username, password, students, teachers) is Student && login.LoginIntoSystem(username, password, students, teachers) is not Teacher)
                {

                    Student student = (Student)login.LoginIntoSystem(username, password, students, teachers);
                    Console.WriteLine("Login as student");
                    Console.WriteLine("-----------------\n");
                    Console.WriteLine(@"You can choose between:
1 - Schedule 
2 - School grades
3 - Homework
4 - Logout");
                     choice = Console.ReadLine();
                     Console.Clear();
                     switch (choice)
                     {
                        case "1":
                            Console.WriteLine("Schedule:\n");
                            if (student.schedule is null)
                            {
                                student.AddSchedule(new Schedule());
                                Console.WriteLine(student.schedule);
                            }
                            else
                                Console.WriteLine(student.schedule);
                            break;
                        case "2":
                            Console.WriteLine("My grades: ");
                            Console.WriteLine(student.grades);
                            break;
                        case "3":
                            Console.WriteLine("My homeworks: ");
                            Console.WriteLine(student.homework);
                            break;
                     }
                }
                if(login.LoginIntoSystem(username, password, students, teachers) is Teacher)
                {
                    Teacher teacher = (Teacher)login.LoginIntoSystem(username, password, students, teachers);
                    Console.WriteLine("Login as teacher");
                    Console.WriteLine("-----------------\n");
                    Console.WriteLine(@"You can choose between:
1 - Schedule 
2 - Students school grades
3 - New homework
4 - Logout");
                    choice = Console.ReadLine();
                    Console.Clear();
                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("Schedule: \n");
                            if (teacher.schedule is null)
                            {
                                teacher.AddSchedule(new Schedule());
                                Console.WriteLine(teacher.schedule);
                            }
                            else
                                Console.WriteLine(teacher.schedule);
                            break;
                        case "2":
                            Console.WriteLine("Students school grades: \n");
                            Console.Write("Name student: ");
                            string nameStudent = Console.ReadLine();
                            Console.Write("Grade: ");
                            string grade = Console.ReadLine();
                            foreach (Student student in students)
                            {
                                if (student.name.Equals(nameStudent))
                                    student.AddGrade(grade);
                            }
                            break;
                        case "3":
                            Console.WriteLine("New homework for students: \n");
                            Console.Write("Name homework: ");
                            string homework = Console.ReadLine();
                            foreach (Student student in students)
                            {
                                student.AddHomework(homework);
                            }                 
                            break;
                    }
                    Console.WriteLine();

                }
                if (choice != "4")
                {
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
            } while (choice != "4");
        }
        /// <summary>
        /// We can add new student to system
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="titles"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void AddStudent(string name, string surname, Student.Titles titles, string username, string password)
        {
            students.Add(new Student(name, surname, titles, username, password));
        }
        /// <summary>
        /// We can add new teacher to system
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="titles"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void AddTeacher(string name, string surname, Student.Titles titles, string username, string password)
        {
            teachers.Add(new Teacher(name, surname, titles, username, password));
        }
    }
}
