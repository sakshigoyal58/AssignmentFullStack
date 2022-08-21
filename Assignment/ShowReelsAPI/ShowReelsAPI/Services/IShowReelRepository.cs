using System;
using ShowReelsAPI.Domain;

namespace ShowReelsAPI.Services
{
    public interface IShowReelRepository
    {
        Task CreateShowReel(ShowReelModel showReelModel);
        Task<List<ShowReelModel>> GetShowReels(string name);
    }
}

