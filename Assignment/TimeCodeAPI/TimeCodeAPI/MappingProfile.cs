using System;
using System.Net;
using TimeCodeAPI.Domain;
using AutoMapper;

namespace TimeCodeAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TimecodeDTO, TimecodeModel>();
            CreateMap<TimecodeModel, TimecodeDTO>();
        }
    }
}

