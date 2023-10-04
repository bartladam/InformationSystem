using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    internal class System
    {
        public List<Student> students { get; private set; }
        public List<Teacher> teachers { get; private set; }
        private Administrator admin { get; init; }
        public System(Administrator admin, Login login)
        {
            students = new List<Student>();
            teachers = new List<Teacher>();
            this.admin = admin;
        }
        public void LoginIntoSystem()
        {

            manipulationSystem();
        }
        private void manipulationSystem()
        {

        }
    }
}
