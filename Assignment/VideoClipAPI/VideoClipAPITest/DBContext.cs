using System;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using VideoClipAPI.Domain;
using VideoClipAPI.Services;

namespace VideoClipAPITest
{
    public class DbContext : IDisposable
    {
        public DbContext()
        {
            configuredSetting = new Settings();

            configuredSetting.ConnectionString = $"mongodb+srv://admin:abc123!@cluster0.on02a2p.mongodb.net/?retryWrites=true&w=majority";
            configuredSetting.Database = $"TelepathyLabs";
            settings = Options.Create(configuredSetting);
            context = new Context(settings);

        }

        public IOptions<Settings> settings { get; }
        public Settings configuredSetting { get; }
        public Context context { get; }

        public void Dispose()
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            //client.DropDatabase(settings.Value.Database);
        }
    }
}

