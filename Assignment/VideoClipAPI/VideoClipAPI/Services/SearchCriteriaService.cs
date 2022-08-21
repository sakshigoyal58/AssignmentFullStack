using System;
using System.Xml.Linq;
using MongoDB.Driver;
using VideoClipAPI.Domain;

namespace VideoClipAPI.Services
{
    public class SearchCriteriaService :ISearchCriteriaService
    {
        private readonly Context _context;
        public SearchCriteriaService(Context context)
        {
            _context = context;
        }

        public async Task<IList<VideoDefinitionModel>> GetAllVideoDefinitions()
        {
            try
            {

                return await _context.VideoDefinitions.Find(_ => true).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<VideoStandardModel>> GetAllVideoStandards()
        {
            try
            {

                return await _context.VideoStandards.Find(_ => true).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CreateUniqueIndexOnVideoDefinitionField()
        {
            // Create the unique index on the field 'title'
            var options = new CreateIndexOptions { Unique = true };
            _context.VideoDefinitions.Indexes.CreateOne("{ Value : 1 }", options);

        }

        private void CreateUniqueIndexOnVideoStandardField()
        {
            // Create the unique index on the field 'title'
            var options = new CreateIndexOptions { Unique = true };
            _context.VideoStandards.Indexes.CreateOne("{ Value : 1 }", options);

        }
    }
}

