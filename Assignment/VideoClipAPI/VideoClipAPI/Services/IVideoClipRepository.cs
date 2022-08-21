using System;
using VideoClipAPI.Domain;

namespace VideoClipAPI.Services
{
    public interface IVideoClipRepository
    {
        Task<List<VideoClipModel>> GetVideoClips(SearchRequest request);
    }
}

