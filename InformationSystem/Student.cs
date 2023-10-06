using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    /// <summary>
    /// Student use Information system to know, about his grades or new homeworks
    /// </summary>
    internal class Student : IStudent
    {
        /// <summary>
        /// Student name is important for giving him homework or grades from test
        /// </summary>
        public string name { get; init; }
        /// <summary>
        /// Student surname is important for giving him homework or grades from test
        /// </summary>
        public string surname { get; init; }
        /// <summary>
        /// Student can have titles from previous education
        /// </summary>
        public enum Titles {Bc, Mgr, Ing, PhD, Dr, DiS, BcA, doc, JUDr, prof, none}
        public Titles title { get; private set; }
        /// <summary>
        /// Via username student can login into the system
        /// </summary>
        public string username { get; private set; }
        /// <summary>
        /// Via password student can login into the system
        /// </summary>
        public string password { get; private set; }
        /// <summary>
        /// Each student has own schedule
        /// </summary>
        public Schedule schedule { get; private set; }
        /// <summary>
        /// Each student has own homeworks. 
        /// </summary>
        public Homework homework { get; private set; }
        /// <summary>
        /// Each student is receiving grades from test etc
        /// </summary>
        public SchoolGrades grades { get; private set; }

        public Student(string name, string surname, Titles title, string username, string password)
        {
            this.name = name;
            this.surname = surname;
            this.title = title;
            this.username = username;
            this.password = password;
            this.homework = new Homework();
            this.grades = new SchoolGrades();
        }
        /// <summary>
        /// When school year started, the student received new schedule
        /// </summary>
        /// <param name="schedule"></param>
        public void AddSchedule(Schedule schedule)
        {
            this.schedule = schedule;
        }
        /// <summary>
        /// Teacher can add homeworks student
        /// </summary>
        /// <param name="newHomework"></param>
        public void AddHomework(string newHomework)
        {
            this.homework.homeworks.Add(newHomework);
        }
        /// <summary>
        /// Teacher has option give student grades from test, homeworks etc
        /// </summary>
        /// <param name="grade"></param>
        public void AddGrade(string grade)
        {
            this.grades.grades.Add(grade);
        }
    }
}
