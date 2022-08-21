using System;
using AutoMapper;
using ShowReelsAPI.Domain;

namespace ShowReelsAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ShowReelDTO, ShowReelModel>();
            CreateMap<ShowReelModel, ShowReelDTO>();
        }
    }
}

