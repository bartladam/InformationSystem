using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    /// <summary>
    /// New homework for students
    /// </summary>
    internal class Homework
    {
        /// <summary>
        /// Each students own list of his homeworks to do
        /// </summary>
        public List<string> homeworks { get; set; }
        public Homework()
        {
            homeworks = new List<string>();
        }
        public override string ToString()
        {
            string allHomeworks = "";
            for (int i = 0; i < homeworks.Count; i++)
            {
                allHomeworks += string.Format("{0}) {1}\n", i + 1, homeworks[i]);
            }
            return allHomeworks;
        }
    }
}
