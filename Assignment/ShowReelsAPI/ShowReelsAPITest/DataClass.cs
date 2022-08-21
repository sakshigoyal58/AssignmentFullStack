using System;
using ShowReelsAPI.Domain;

namespace ShowReelsAPITest
{
    public class DataClass
    {
        public ShowReelModel CreateShowReelWithOneVideoClip()
        {
            VideoClipModel videoClip = new VideoClipModel()
            {
                Id = new Guid(),
                StartTime = new TimecodeModel()
                {
                    Hour = 00,
                    Min = 00,
                    Sec = 00,
                    Frames = 00
                },
                EndTime = new TimecodeModel()
                {
                    Hour = 00,
                    Min = 00,
                    Sec = 30,
                    Frames = 23
                }
            };

            return new ShowReelModel()
            {
                Name = "dummy_reel",
                VideoDefinition = "HD",
                VideoStandard = "PAL",
                TotalDuration = new TimecodeModel()
                {
                    Hour = 00,
                    Min = 00,
                    Sec = 30,
                    Frames = 23
                },
                VideoClips = new List<VideoClipModel> { videoClip }
            };
        }

        public ShowReelModel CreateShowReelWithSameNameVideoClip()
        {
            VideoClipModel videoClip = new VideoClipModel()
            {
                Id = new Guid(),
                StartTime = new TimecodeModel()
                {
                    Hour = 00,
                    Min = 00,
                    Sec = 00,
                    Frames = 00
                },
                EndTime = new TimecodeModel()
                {
                    Hour = 00,
                    Min = 00,
                    Sec = 30,
                    Frames = 23
                }
            };

            return new ShowReelModel()
            {
                Name = "dummy_reel1",
                VideoDefinition = "HD",
                VideoStandard = "PAL",
                TotalDuration = new TimecodeModel()
                {
                    Hour = 00,
                    Min = 00,
                    Sec = 30,
                    Frames = 23
                },
                VideoClips = new List<VideoClipModel> { videoClip }
            };
        }

        public ShowReelModel CreateShowReelWithMultipleVideoClip()
        {
            VideoClipModel videoClip1 = new VideoClipModel()
            {
                Id = new Guid(),
                StartTime = new TimecodeModel()
                {
                    Hour = 00,
                    Min = 00,
                    Sec = 00,
                    Frames = 00
                },
                EndTime = new TimecodeModel()
                {
                    Hour = 00,
                    Min = 00,
                    Sec = 30,
                    Frames = 23
                }
            };

            VideoClipModel videoClip2 = new VideoClipModel()
            {
                Id = new Guid(),
                StartTime = new TimecodeModel()
                {
                    Hour = 00,
                    Min = 00,
                    Sec = 00,
                    Frames = 00
                },
                EndTime = new TimecodeModel()
                {
                    Hour = 00,
                    Min = 00,
                    Sec = 45,
                    Frames = 23
                }
            };

            return new ShowReelModel()
            {
                Name = "dummy_reel2",
                VideoDefinition = "HD",
                VideoStandard = "PAL",
                TotalDuration = new TimecodeModel()
                {
                    Hour = 00,
                    Min = 01,
                    Sec = 16,
                    Frames = 22
                },
                VideoClips = new List<VideoClipModel> { videoClip1,videoClip2 }
            };
        }

        public ShowReelModel CreateShowReelWhereNameIsNull()
        {
            VideoClipModel videoClip = new VideoClipModel()
            {
                Id = new Guid(),
                StartTime = new TimecodeModel()
                {
                    Hour = 00,
                    Min = 00,
                    Sec = 00,
                    Frames = 00
                },
                EndTime = new TimecodeModel()
                {
                    Hour = 00,
                    Min = 00,
                    Sec = 30,
                    Frames = 23
                }
            };

            return new ShowReelModel()
            {
                VideoDefinition = "HD",
                VideoStandard = "PAL",
                TotalDuration = new TimecodeModel()
                {
                    Hour = 00,
                    Min = 00,
                    Sec = 30,
                    Frames = 23
                },
                VideoClips = new List<VideoClipModel> { videoClip }
            };
        }

        public ShowReelModel CreateShowReelWhereVideoClipsAreZero()
        {
            return new ShowReelModel()
            {
                Name = "Dummy_reel3",
                VideoDefinition = "HD",
                VideoStandard = "PAL",
                TotalDuration = new TimecodeModel()
                {
                    Hour = 00,
                    Min = 00,
                    Sec = 30,
                    Frames = 23
                }
            };
        }

        public ShowReelModel CreateShowReelWhereTotalDurationIsNull()
        {
            VideoClipModel videoClip = new VideoClipModel()
            {
                Id = new Guid(),
                StartTime = new TimecodeModel()
                {
                    Hour = 00,
                    Min = 00,
                    Sec = 00,
                    Frames = 00
                },
                EndTime = new TimecodeModel()
                {
                    Hour = 00,
                    Min = 00,
                    Sec = 30,
                    Frames = 23
                }
            };

            return new ShowReelModel()
            {
                Name = "dummy_reel4",
                VideoDefinition = "HD",
                VideoStandard = "PAL",
                VideoClips = new List<VideoClipModel> { videoClip }
            };
        }

        public ShowReelModel CreateShowReelWhereVideoDefinitionIsNull()
        {
            VideoClipModel videoClip = new VideoClipModel()
            {
                Id = new Guid(),
                StartTime = new TimecodeModel()
                {
                    Hour = 00,
                    Min = 00,
                    Sec = 00,
                    Frames = 00
                },
                EndTime = new TimecodeModel()
                {
                    Hour = 00,
                    Min = 00,
                    Sec = 30,
                    Frames = 23
                }
            };

            return new ShowReelModel()
            {
                Name = "dummy_reel5",
                VideoStandard = "PAL",
                TotalDuration = new TimecodeModel()
                {
                    Hour = 00,
                    Min = 00,
                    Sec = 30,
                    Frames = 23
                },
                VideoClips = new List<VideoClipModel> { videoClip }
            };
        }

        public ShowReelModel CreateShowReelWhereVideoStandardIsNull()
        {
            VideoClipModel videoClip = new VideoClipModel()
            {
                Id = new Guid(),
                StartTime = new TimecodeModel()
                {
                    Hour = 00,
                    Min = 00,
                    Sec = 00,
                    Frames = 00
                },
                EndTime = new TimecodeModel()
                {
                    Hour = 00,
                    Min = 00,
                    Sec = 30,
                    Frames = 23
                }
            };

            return new ShowReelModel()
            {
                Name = "dummy_reel6",
                VideoDefinition = "HD",
                TotalDuration = new TimecodeModel()
                {
                    Hour = 00,
                    Min = 00,
                    Sec = 30,
                    Frames = 23
                },
                VideoClips = new List<VideoClipModel> { videoClip }
            };
        }
    }
}

