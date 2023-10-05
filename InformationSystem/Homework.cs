using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    internal class Homework
    {
        public List<string> homeworks { get; set; }
        public Homework()
        {
            homeworks = new List<string>();
        }
        public override string ToString()
        {
            string allHomeworks = "";
            foreach (string homework in homeworks)
            {
                allHomeworks += homework + "\n";
            }
            return allHomeworks;
        }
    }
}
