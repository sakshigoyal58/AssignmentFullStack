using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace VideoClipAPI.Domain
{
    public class VideoDefinitionModel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("Value")]
        public string Value { get; set; }
    }
}

