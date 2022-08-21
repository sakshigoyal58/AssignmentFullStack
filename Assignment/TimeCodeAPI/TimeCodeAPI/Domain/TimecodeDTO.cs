using System;
namespace TimeCodeAPI.Domain
{
    public class TimecodeDTO
    {
        public TimeModel TotalTimeDuration { get; set; }

        public TimeModel Time { get; set; }

        public float MillisecPerFrame { get; set; }

        public string ErrorMessage { get; set; }
    }
}

