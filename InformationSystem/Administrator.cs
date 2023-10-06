using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    /// <summary>
    /// Administrator manage system
    /// </summary>
    internal class Administrator:Teacher
    {
        /// <summary>
        /// Administrator manage system
        /// </summary>
        public SystemInformation system { get; set; }
        public Administrator(string name, string surname, Titles title, string username, string password) : base(name, surname, title, username, password)
        {
            
        }
    }
}
