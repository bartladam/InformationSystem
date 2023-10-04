using System;
using System.Collections.Generic;
using System.Linq;
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

        public Student(string name, string surname, Titles title)
        {
            this.name = name;
            this.surname = surname;
            this.title = title;
        }
        public void ControlSystem(System system)
        {
             
        }
    }
}
