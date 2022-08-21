using System;
namespace VideoClipAPI.Domain
{
    public class VideoClipDTO
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string VideoStandard { get; set; }

        public string Videodefinition { get; set; }

        public TimecodeModel StartTime { get; set; }

        public TimecodeModel EndTime { get; set; }
    }
}

