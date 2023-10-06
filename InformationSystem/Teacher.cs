using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    /// <summary>
    /// Teacher give students grades or new homeworks to do
    /// </summary>
    internal class Teacher:Student
    {
        public Teacher(string name, string surname, Titles title, string username, string password): base (name, surname, title, username, password)
        {
            
        }

    }
}
