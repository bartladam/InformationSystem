using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    internal class SchoolGrades
    {
        public List<string> grades { get; set; }
        public SchoolGrades()
        {
            grades = new List<string>();
        }
        public override string ToString()
        {
            string allGrades = "";
            foreach (string grades in grades)
            {
                allGrades += grades + "\n";
            }
            return allGrades;
        }
    }
}
