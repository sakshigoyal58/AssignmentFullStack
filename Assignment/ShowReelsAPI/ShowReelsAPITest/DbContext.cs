using System;
using Microsoft.Extensions.Configuration;
using System.Xml.Linq;
using Microsoft.Extensions.Hosting;
using MongoDB.Driver;
using ShowReelsAPI.Domain;
using ShowReelsAPI.Services;
using Microsoft.Extensions.Options;

namespace ShowReelsAPITest
{
    public class DbContext :IDisposable
    {
        public DbContext()
        {
            configuredSetting = new Settings();

            configuredSetting.ConnectionString = $"mongodb+srv://admin:abc123!@cluster0.on02a2p.mongodb.net/?retryWrites=true&w=majority";
            configuredSetting.Database = $"test_db";
            settings = Options.Create(configuredSetting);
            context = new ShowReelContext(settings);

        }

        public IOptions<Settings> settings { get; }
        public Settings configuredSetting { get; }
        public ShowReelContext context { get; }

        public void Dispose()
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            //client.DropDatabase(settings.Value.Database);
        }
    }
}

