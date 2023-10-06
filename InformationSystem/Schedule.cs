using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem
{
    /// <summary>
    /// Schedule for teacher or student. Both use it
    /// </summary>
    internal class Schedule
    {
        /// <summary>
        /// All subjects what school offer
        /// </summary>
        public string[] subjects { get; private set; }
        /// <summary>
        /// Days of school week
        /// </summary>
        private DayOfWeek[] days{ get; set; }
        /// <summary>
        /// Used it for random subject in specific day
        /// </summary>
        private Random random { get; set; }
        /// <summary>
        /// Here is saved each day of school week with subjects
        /// </summary>
        private List<string> personalSchedule { get; set; }
        /// <summary>
        /// Time when lesson start
        /// </summary>
        private DateTime timeLesson { get; set; }
        public Schedule()
        {
            subjects = new string[] {"Math", "English language", "Biology","Physics", "Programming", "Czech language", "Art education", "Civics education" };
            days = new DayOfWeek[] {DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday};
            personalSchedule = new List<string>();
            random = new Random();
            ManageSchedule();
        }
        /// <summary>
        /// Is maked the new schedule for student or teacher
        /// </summary>
        private void ManageSchedule()
        {
            for (int i = 0; i < days.Length; i++)
            {
                string resultSchedule = "";
                resultSchedule += "\n" + days[i].ToString() + "\n";
                for (int j = 0; j < random.Next(4, 7); j++)
                {
                    timeLesson = new DateTime(2023, 8, 8, 8 + j , 0, 0);
                    resultSchedule += string.Format("Subject: {0}, Time: {1}\n", subjects[random.Next(subjects.Length)], timeLesson.ToShortTimeString());
                }
                personalSchedule.Add(resultSchedule);
            }
        }
        public override string ToString()
        {
            string result = "";
           
            foreach (string schedule in personalSchedule)
            {
                result += schedule;
            }
            return result;
        }
    }
}
