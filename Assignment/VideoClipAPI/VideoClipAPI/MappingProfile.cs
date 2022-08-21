using System;
using AutoMapper;
using VideoClipAPI.Domain;

namespace VideoClipAPI
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<SearchCriteriaModel, SearchCriteriaDTO>();
            CreateMap<VideoClipModel, VideoClipDTO>();
        }
    }
}

