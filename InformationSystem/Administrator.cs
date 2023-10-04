using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    internal class Administrator:Teacher
    {
        public Administrator(string name, string surname, Titles title) : base(name, surname, title)
        {
            
        }
    }
}
