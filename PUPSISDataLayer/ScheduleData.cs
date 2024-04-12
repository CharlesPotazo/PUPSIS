using PUPSISModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUPSISDataLayer
{
    public class ScheduleData
    {
        public List<Schedule> BSIT2schedules = new List<Schedule>();
        public List<Schedule> BSIT3schedules = new List<Schedule>();

        public ScheduleData()
        {
            RegisteredBSIT2Schedule();
            RegisteredBSIT3Schedule();
        }

        public void RegisteredBSIT2Schedule()
        {
            Schedule schedule1 = new Schedule { subject = "Programming", room = "201", dateTime = "Monday 1:00pm - 5:00pm" };
            BSIT2schedules.Add(schedule1);
            Schedule schedule2 = new Schedule { subject = "OOP", room = "202", dateTime = "Tuesday 7:00am - 12:00pm" };
            BSIT2schedules.Add(schedule2);
            Schedule schedule3 = new Schedule { subject = "Integrative", room = "301", dateTime = "Saturday 2:00pm - 7:00pm" };
            BSIT2schedules.Add(schedule3);
        }
        public void RegisteredBSIT3Schedule()
        {
            Schedule schedule1 = new Schedule { subject = "Fundamentals of Research", room = "301", dateTime = "Wednesday 7:00am - 12:00pm" };
            BSIT3schedules.Add(schedule1);
            Schedule schedule2 = new Schedule { subject = "Multimedia", room = "201", dateTime = "Monday 9:00am - 12:00pm" };
            BSIT3schedules.Add(schedule2);
            Schedule schedule3 = new Schedule { subject = "Web Development", room = "202", dateTime = "Saturday 7:00am - 12:00pm" };
            BSIT3schedules.Add(schedule3);
        }

        public List<Schedule> getBSIT2Schedule()
        {
            return BSIT2schedules;
        }

        public List<Schedule> getBSIT3Schedule()
        {
            return BSIT3schedules;
        }
    }
}
