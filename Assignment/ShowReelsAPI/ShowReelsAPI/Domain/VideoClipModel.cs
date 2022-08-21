using System;
namespace ShowReelsAPI.Domain
{
    public class VideoClipModel
    {
        public Guid Id { get; set; }

        public TimecodeModel StartTime { get; set; }

        public TimecodeModel EndTime { get; set; }
    }
}

