using System;
using TimeCodeAPI.Domain;

namespace TimeCodeAPI.Services
{
    public interface ITimecodeService
    {
        void AddTimeToTotalTimeDuration(TimecodeModel timecodeDTO);
        void RemoveTimeFromTotalTimeDuration(TimecodeModel timecodeDTO);
    }
}

