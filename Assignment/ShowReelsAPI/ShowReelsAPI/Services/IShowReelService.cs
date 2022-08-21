using System;
using ShowReelsAPI.Domain;

namespace ShowReelsAPI.Services
{
    public interface IShowReelService
    {
        Task AddShowReel(ShowReelModel showReel);
        Task<List<ShowReelModel>> GetShowReelsByName(String name);
    }
}

