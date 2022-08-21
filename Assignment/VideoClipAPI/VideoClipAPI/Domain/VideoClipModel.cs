using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace VideoClipAPI.Domain
{
    public class VideoClipModel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Description")]
        public string Description { get; set; }

        [BsonElement("StartTime")]
        public TimecodeModel StartTime { get; set; }

        [BsonElement("EndTime")]
        public TimecodeModel EndTime { get; set; }

        [BsonElement("VideoStandard")]
        public string VideoStandard { get; set; }

        [BsonElement("Videodefinition")]
        public string Videodefinition { get; set; }
    }
}

