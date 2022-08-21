using System;
using System.Xml.Linq;
using VideoClipAPI.Services;

namespace VideoClipAPITest
{
    public class VideoClipServiceTest :IClassFixture<DbContext>
    {
        private readonly DbContext _context;
        private readonly IVideoClipService _service;
        private readonly DataClass _data;

        public VideoClipServiceTest(DbContext context)
        {
            _data = new DataClass();
            _context = context;
            _service = new VideoClipService(_context.context);
        }

        [Fact]
        public async Task GetVideoClipForHDDefinition()
        {
            await _service.InsertVideoClip(_data.CreateHDDefinitionVideoClip());
            var data = _service.GetVideoClips(_data.CreateSearchRequestHDAndPAL());

            data.Result.Any(x => x.Name.Equals("dummy_reel_HD"));
        }

        [Fact]
        public async Task GetVideoClipForSDDefinition()
        {
            await _service.InsertVideoClip(_data.CreateSDDefinitionVideoClip());
            var data = _service.GetVideoClips(_data.CreateSearchRequestSDAndPAL());

            data.Result.Any(x => x.Name.Equals("dummy_reel_SD"));
        }

    }
}

