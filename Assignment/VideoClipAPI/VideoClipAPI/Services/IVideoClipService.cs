using System;
using VideoClipAPI.Domain;

namespace VideoClipAPI.Services
{
    public interface IVideoClipService
    {
        Task<List<VideoClipModel>> GetVideoClips(SearchRequest request);

        Task InsertVideoClip(VideoClipModel videoClipModel);
    }
}

