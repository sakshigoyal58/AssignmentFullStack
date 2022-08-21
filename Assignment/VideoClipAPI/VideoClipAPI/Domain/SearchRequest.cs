using System;
using System.ComponentModel.DataAnnotations;

namespace VideoClipAPI.Domain
{
    public class SearchRequest
    {
        [Required]
        public string VideoDefinition { get; set; }

        [Required]
        public string VideoStandard { get; set; }
    }
}

