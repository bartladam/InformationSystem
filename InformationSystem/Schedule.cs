using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    internal class Schedule
    {
        public string[] subjects { get; private set; }
        private DayOfWeek[] days{ get; set; }
        private Random random { get; set; }
        private List<string> personalSchedule { get; set; }
        private DateTime timeLesson { get; set; }
        public Schedule()
        {
            subjects = new string[] {"Math", "English language", "Biology","Physics", "Programming"};
            days = new DayOfWeek[] {DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday};
            personalSchedule = new List<string>();
        }
        public void ManageSchedule()
        {
            for (int i = 0; i < days.Length; i++)
            {
                timeLesson = new DateTime(0, 0, 0, 8 + i, 0, 0);
                personalSchedule.Add(string.Format("Day: {0}, Subject: {1}, Time: {2}\n", days[i].ToString(), subjects[random.Next(subjects.Length)], timeLesson.ToShortTimeString()));
            }
        }
        public override string ToString()
        {
            string resultSchedule = "";
            foreach (string schedule in personalSchedule)
            {
                resultSchedule += schedule;
            }
            return resultSchedule;
        }
    }
}
