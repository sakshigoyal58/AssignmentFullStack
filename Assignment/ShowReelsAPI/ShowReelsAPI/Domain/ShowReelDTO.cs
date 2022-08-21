using System;
using System.ComponentModel.DataAnnotations;

namespace ShowReelsAPI.Domain
{
    public class ShowReelDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string VideoDefinition { get; set; }

        [Required]
        public string VideoStandard { get; set; }

        [Required]
        public TimecodeModel TotalDuration { get; set; }

        [Required]
        public IList<VideoClipModel> VideoClips { get; set; }
    }
}

