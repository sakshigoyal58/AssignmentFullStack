using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using ShowReelsAPI.Domain;

namespace ShowReelsAPI.Services
{
    public class ShowReelContext
    {
        private readonly IMongoDatabase _database = null;

        public ShowReelContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<ShowReelModel> ShowReels
        {
            get
            {
                return _database.GetCollection<ShowReelModel>("ShowReel");
            }
        }
    }
}

