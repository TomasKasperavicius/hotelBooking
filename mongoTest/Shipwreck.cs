using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace mongoTest
{
    [BsonIgnoreExtraElements]
    public class Shipwreck
    {
        public ObjectId Id { get; set; }
        [BsonElement("feature_type")]
        public string FeatureType { get; set; }
        [BsonElement("chart")]
        public string Chart { get; set; }
        [BsonElement("latdec")]
        public double Latitude { get; set; }
        [BsonElement("londec")]
        public double Longtitude { get; set;}
    }
}
