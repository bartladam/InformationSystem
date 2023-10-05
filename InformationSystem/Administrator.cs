using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    internal class Administrator:Teacher
    {
        public Administrator(string name, string surname, Titles title, string username, string password) : base(name, surname, title, username, password)
        {
            
        }
    }
}
