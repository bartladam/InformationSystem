using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    internal class Student : IStudent
    {
        public string name { get; init; }
        public string surname { get; init; }
        public enum Titles {Bc, Mgr, Ing, PhD, Dr, DiS, BcA, doc, JUDr, prof, none}
        public Titles title { get; private set; }
        public string username { get; private set; }
        public string password { get; private set; }
        public Schedule schedule { get; private set; }
        public Homework homework { get; private set; }
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
        public void AddSchedule(Schedule schedule)
        {
            this.schedule = schedule;
        }
        public void AddHomework(string newHomework)
        {
            this.homework.homeworks.Add(newHomework);
        }
        public void AddGrade(string grade)
        {
            this.grades.grades.Add(grade);
        }
    }
}
