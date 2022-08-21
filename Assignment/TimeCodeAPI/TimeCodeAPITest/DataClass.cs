using System;
using TimeCodeAPI.Domain;

namespace TimeCodeAPITest
{
    public class DataClass
    {
        public TimecodeModel CreateModelToAddVideoFirstTime()
        {
            TimeModel totalTimeDuration = new TimeModel()
            {
                Hour = 00,
                Minutes = 00,
                Seconds = 00,
                Frames = 00
            };

            TimeModel time = new TimeModel()
            {
                Hour = 00,
                Minutes = 00,
                Seconds = 30,
                Frames = 23
            };


            return new TimecodeModel()
            {
                TotalTimeDuration = totalTimeDuration,
                Time = time,
                MillisecPerFrame = 40
            };
        }

        public TimecodeModel CreateModelForPALVideoToAdd()
        {
            TimeModel totalTimeDuration = new TimeModel()
            {
                Hour = 00,
                Minutes = 01,
                Seconds = 15,
                Frames = 24
            };

            TimeModel time = new TimeModel()
            {
                Hour = 00,
                Minutes = 00,
                Seconds = 30,
                Frames = 23
            };


            return new TimecodeModel()
            {
                TotalTimeDuration = totalTimeDuration,
                Time = time,
                MillisecPerFrame = 40
            };
        }

        public TimecodeModel CreateModelForNTSCVideoToAdd()
        {
            TimeModel totalTimeDuration = new TimeModel()
            {
                Hour = 00,
                Minutes = 01,
                Seconds = 15,
                Frames = 29
            };

            TimeModel time = new TimeModel()
            {
                Hour = 00,
                Minutes = 00,
                Seconds = 30,
                Frames = 28
            };


            return new TimecodeModel()
            {
                TotalTimeDuration = totalTimeDuration,
                Time = time,
                MillisecPerFrame = 33.33f
            };
        }

        public TimecodeModel CreateModelForPALVideoToRemove()
        {
            TimeModel totalTimeDuration = new TimeModel()
            {
                Hour = 00,
                Minutes = 01,
                Seconds = 15,
                Frames = 24
            };

            TimeModel time = new TimeModel()
            {
                Hour = 00,
                Minutes = 00,
                Seconds = 30,
                Frames = 22
            };


            return new TimecodeModel()
            {
                TotalTimeDuration = totalTimeDuration,
                Time = time,
                MillisecPerFrame = 40
            };
        }

        public TimecodeModel CreateDataTimeForNTSCVideoToRemove()
        {
            TimeModel totalTimeDuration = new TimeModel()
            {
                Hour = 00,
                Minutes = 01,
                Seconds = 15,
                Frames = 27
            };

            TimeModel time = new TimeModel()
            {
                Hour = 00,
                Minutes = 00,
                Seconds = 30,
                Frames = 26
            };


            return new TimecodeModel()
            {
                TotalTimeDuration = totalTimeDuration,
                Time = time,
                MillisecPerFrame = 33.33f
            };
        }

        public TimecodeModel CreateModelWhereSecondsAreGreater()
        {
            TimeModel totalTimeDuration = new TimeModel()
            {
                Hour = 00,
                Minutes = 01,
                Seconds = 15,
                Frames = 24
            };

            TimeModel time = new TimeModel()
            {
                Hour = 00,
                Minutes = 01,
                Seconds = 30,
                Frames = 00
            };


            return new TimecodeModel()
            {
                TotalTimeDuration = totalTimeDuration,
                Time = time,
                MillisecPerFrame = 40
            };
        }

        public TimecodeModel CreateModelWhereFramesAreGreater()
        {
            TimeModel totalTimeDuration = new TimeModel()
            {
                Hour = 00,
                Minutes = 01,
                Seconds = 15,
                Frames = 23
            };

            TimeModel time = new TimeModel()
            {
                Hour = 00,
                Minutes = 01,
                Seconds = 14,
                Frames = 24
            };


            return new TimecodeModel()
            {
                TotalTimeDuration = totalTimeDuration,
                Time = time,
                MillisecPerFrame = 40
            };
        }

        public TimecodeModel CreateModelWhereCalculatedTimeIsEqual()
        {
            TimeModel totalTimeDuration = new TimeModel()
            {
                Hour = 00,
                Minutes = 00,
                Seconds = 59,
                Frames = 25
            };

            TimeModel time = new TimeModel()
            {
                Hour = 00,
                Minutes = 01,
                Seconds = 00,
                Frames = 00
            };


            return new TimecodeModel()
            {
                TotalTimeDuration = totalTimeDuration,
                Time = time,
                MillisecPerFrame = 40
            };
        }

        public TimecodeModel CreateDataTimeForPALVideoToNotRemove()
        {
            TimeModel totalTimeDuration = new TimeModel()
            {
                Hour = 00,
                Minutes = 01,
                Seconds = 15,
                Frames = 40
            };

            TimeModel time = new TimeModel()
            {
                Hour = 00,
                Minutes = 01,
                Seconds = 15,
                Frames = 50
            };


            return new TimecodeModel()
            {
                TotalTimeDuration = totalTimeDuration,
                Time = time,
                MillisecPerFrame = 40
            };
        }

        public TimecodeModel CreateDataTimeNTSCVideoToNotRemove()
        {
            TimeModel totalTimeDuration = new TimeModel()
            {
                Hour = 00,
                Minutes = 01,
                Seconds = 15,
                Frames = 40
            };

            TimeModel time = new TimeModel()
            {
                Hour = 00,
                Minutes = 01,
                Seconds = 15,
                Frames = 50
            };


            return new TimecodeModel()
            {
                TotalTimeDuration = totalTimeDuration,
                Time = time,
                MillisecPerFrame = 33.33f
            };
        }
    }
}

