using System;
namespace TimeCodeAPI.Domain
{
    public class TimecodeModel
    {
        private TimeModel totalTimeDuration;

        private TimeModel time;

        public TimeModel TotalTimeDuration
        {
            get { return totalTimeDuration; }
            set { if (value == null) totalTimeDuration = new TimeModel(); else totalTimeDuration = value; }
        }
       
        public TimeModel Time
        { get { return time; }
          set { if (value == null) time = new TimeModel(); else time = value; }
        }

        public float MillisecPerFrame { get; set; }

        public string ErrorMessage { get; set; }
    }
}

