using System;
using TimeCodeAPI.Domain;

namespace TimeCodeAPI.Services
{
    public class TimecodeService :ITimecodeService
    {
        private const int _TimeSpanDays = 0;

        public void AddTimeToTotalTimeDuration(TimecodeModel timecodeModel)
        {
             var totalTimeDuration = CreateToTalTimeDurationTimeSpan(timecodeModel);
             var newtimeSpan = CreateTimeSpanForOperations(timecodeModel);

             totalTimeDuration = totalTimeDuration + newtimeSpan;

             UpdateTotalTimeDurationModel(timecodeModel , totalTimeDuration);
        }

        public void RemoveTimeFromTotalTimeDuration(TimecodeModel timecodeModel)
        {
            var totalTimeDuration = CreateToTalTimeDurationTimeSpan(timecodeModel);
            var newtimeSpan = CreateTimeSpanForOperations(timecodeModel);

            if (totalTimeDuration >= newtimeSpan)
            {
                totalTimeDuration = totalTimeDuration - newtimeSpan;
                UpdateTotalTimeDurationModel(timecodeModel, totalTimeDuration);
            }
            else
                timecodeModel.ErrorMessage = "Time to be removed is greater than Total Duration";
            
        }

        private TimeSpan CreateToTalTimeDurationTimeSpan(TimecodeModel timecodeModel)
        {
            return new TimeSpan(_TimeSpanDays,
                                           timecodeModel.TotalTimeDuration.Hour,
                                           timecodeModel.TotalTimeDuration.Minutes,
                                           timecodeModel.TotalTimeDuration.Seconds,
                                           (int)Math.Round(timecodeModel.TotalTimeDuration.Frames * timecodeModel.MillisecPerFrame));
        }

        private TimeSpan CreateTimeSpanForOperations(TimecodeModel timecodeModel)
        { 
            return new TimeSpan(_TimeSpanDays,
                                        timecodeModel.Time.Hour,
                                        timecodeModel.Time.Minutes,
                                        timecodeModel.Time.Seconds,
                                        (int)Math.Round(timecodeModel.Time.Frames * timecodeModel.MillisecPerFrame));
        }

        private void UpdateTotalTimeDurationModel(TimecodeModel timecodeModel, TimeSpan totalTimeDuration)
        {
            timecodeModel.TotalTimeDuration.Minutes = totalTimeDuration.Minutes;
            timecodeModel.TotalTimeDuration.Seconds = totalTimeDuration.Seconds;
            timecodeModel.TotalTimeDuration.Frames = (int)Math.Round(totalTimeDuration.Milliseconds / timecodeModel.MillisecPerFrame);
        }
    }
}

