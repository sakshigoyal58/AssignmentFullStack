using System;
using System.Linq;
using AutoMapper;
using VideoClipAPI.Domain;

namespace VideoClipAPI.Services
{
    public class VideoClipRepository :IVideoClipRepository
    {
        private readonly IVideoClipService _videoClipService;
        private readonly IMapper _mapper;

        public VideoClipRepository(IVideoClipService videoClipService, IMapper mapper)
        {
            _videoClipService = videoClipService;
            _mapper = mapper;
        }

        public async Task<List<VideoClipModel>> GetVideoClips(SearchRequest request)
        {
            return await _videoClipService.GetVideoClips(request);
        }

    }
}
