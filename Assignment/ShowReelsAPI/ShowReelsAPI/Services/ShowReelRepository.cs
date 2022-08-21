using System;
using ShowReelsAPI.Domain;

namespace ShowReelsAPI.Services
{
    public class ShowReelRepository :IShowReelRepository
    {
        private readonly IShowReelService _service;
        public ShowReelRepository(IShowReelService service)
        {
            _service = service;
        }

        public async Task CreateShowReel(ShowReelModel showReelModel)
        {
            await _service.AddShowReel(showReelModel);
        }

        public async Task<List<ShowReelModel>> GetShowReels(string name)
        {
            return await _service.GetShowReelsByName(name);
        }
    }
}

