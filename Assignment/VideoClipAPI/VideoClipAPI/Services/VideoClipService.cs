using System;
using System.Xml.Linq;
using MongoDB.Driver;
using VideoClipAPI.Domain;

namespace VideoClipAPI.Services
{
    public class VideoClipService :IVideoClipService
    {
        private readonly Context _context;
        public VideoClipService(Context context)
        {
            _context = context;
        }

        public async Task<List<VideoClipModel>> GetVideoClips(SearchRequest request)
        {
            try
            {
                return await _context.VideoClips.Find(
                                     clips => clips.Videodefinition == request.VideoDefinition
                                  && clips.VideoStandard == request.VideoStandard)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task InsertVideoClip(VideoClipModel videoClipModel)
        {
            try
            {
                CreateUniqueIndexOnNameField();
                await _context.VideoClips.InsertOneAsync(videoClipModel);
            }
            catch (MongoDB.Driver.MongoWriteException ex)
            {
                throw ex;
            }
            catch (NullReferenceException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CreateUniqueIndexOnNameField()
        {
            // Create the unique index on the field 'title'
            var options = new CreateIndexOptions { Unique = true };
            _context.VideoClips.Indexes.CreateOne("{ Name : 1 }", options);

        }
    }
}

