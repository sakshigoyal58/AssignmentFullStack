using System;
using VideoClipAPI.Domain;

namespace VideoClipAPITest
{
    public class DataClass
    {
        public VideoClipModel CreateHDDefinitionVideoClip()
        {
            var startTime = new TimecodeModel()
            {
                Hour =0,
                Minutes =0,
                Sec =0,
                Frames=0
            };

            var endTime = new TimecodeModel()
            {
                Hour = 0,
                Minutes = 0,
                Sec = 30,
                Frames = 0
            };

            return new VideoClipModel()
            {
                Name = "dummy_reel_1",
                Description = "dummy_description",
                StartTime = startTime,
                EndTime = endTime,
                Videodefinition = "HD",
                VideoStandard = "PAL"
            };
        }

        public VideoClipModel CreateSDDefinitionVideoClip()
        {
            var startTime = new TimecodeModel()
            {
                Hour = 0,
                Minutes = 0,
                Sec = 0,
                Frames = 0
            };

            var endTime = new TimecodeModel()
            {
                Hour = 0,
                Minutes = 0,
                Sec = 30,
                Frames = 0
            };

            return new VideoClipModel()
            {
                Name = "dummy_reel_SD",
                Description = "dummy_description",
                StartTime = startTime,
                EndTime = endTime,
                Videodefinition = "SD",
                VideoStandard = "PAL"
            };
        }

        public SearchRequest CreateSearchRequestHDAndPAL()
        {
            return new SearchRequest()
            {
                VideoDefinition = "PAL",
                VideoStandard = "HD"
            };
        }

        public SearchRequest CreateSearchRequestSDAndPAL()
        {
            return new SearchRequest()
            {
                VideoDefinition = "PAL",
                VideoStandard = "SD"
            };
        }
    }
}

