using System;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using ShowReelsAPI.Domain;

namespace ShowReelsAPI.Services
{
    public class ShowReelService : IShowReelService
    {
        private readonly ShowReelContext _context;

        public ShowReelService( ShowReelContext context)
        {
            _context = context;
        }

        public async Task AddShowReel(ShowReelModel showReelModel)
        {
            try
            {
                CreateUniqueIndexOnNameField();
                await _context.ShowReels.InsertOneAsync(showReelModel);
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

        public async Task<List<ShowReelModel>> GetShowReelsByName(string name)
        {
            try
            {
                
                return await _context.ShowReels.Find(reels => reels.Name == name).ToListAsync();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void CreateUniqueIndexOnNameField()
        {
            // Create the unique index on the field 'title'
            var options = new CreateIndexOptions { Unique = true };
            _context.ShowReels.Indexes.CreateOne("{ name : 1 }", options);

        }

    }
}

