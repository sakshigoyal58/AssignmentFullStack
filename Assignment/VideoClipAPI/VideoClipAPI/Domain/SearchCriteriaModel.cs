using System;
namespace VideoClipAPI.Domain
{
    public class SearchCriteriaModel
    {
        public IList<VideoDefinitionModel> VideoDefinitions { get; set; }

        public IList<VideoStandardModel> VideoStandards { get; set; }
    }
}

