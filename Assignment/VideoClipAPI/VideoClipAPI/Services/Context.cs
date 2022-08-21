using System;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using VideoClipAPI.Domain;

namespace VideoClipAPI.Services
{
    public class Context
    {
        private readonly IMongoDatabase _database = null;
        public Context(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<VideoDefinitionModel> VideoDefinitions
        {
            get
            {
                return _database.GetCollection<VideoDefinitionModel>("VideoDefinitions");
            }
        }

        public IMongoCollection<VideoStandardModel> VideoStandards
        {
            get
            {
                return _database.GetCollection<VideoStandardModel>("VideoStandard");
            }
        }

        public IMongoCollection<VideoClipModel> VideoClips
        {
            get
            {
                return _database.GetCollection<VideoClipModel>("VideoClip");
            }
        }


    }

}


