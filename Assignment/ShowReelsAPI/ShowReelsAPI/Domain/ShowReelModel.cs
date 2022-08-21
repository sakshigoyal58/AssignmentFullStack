using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShowReelsAPI.Domain
{
    public class ShowReelModel
    {
      
        private Guid id;

        [BsonId]
        public ObjectId InternalId { get; set; }

        [BsonElement("Id")]
        public Guid Id
        {
            get { return id; }
            set { id = new Guid(); }
        }

        [BsonElement("name")]       
        public string Name { get; set; }

        [BsonElement("videoDefinition")]
        public string VideoDefinition { get; set; }

        
        [BsonElement("videoStandard")]
        public string VideoStandard { get; set; }

        [BsonElement("TotalDuration")]
        public TimecodeModel TotalDuration { get; set; }

        [BsonElement("videoClips")]
        public IList<VideoClipModel> VideoClips { get; set; }
    }
}

