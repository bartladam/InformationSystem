using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    internal interface IStudent
    {
        string name { get; }
        string surname { get; }
        string username { get; }
        string password { get; }
        Schedule schedule { get; }
        Homework homework { get; }
        SchoolGrades grades { get; }
        void AddSchedule(Schedule schedule);
        void AddHomework(string newHomework);
        void AddGrade(string grade);

    }
}
